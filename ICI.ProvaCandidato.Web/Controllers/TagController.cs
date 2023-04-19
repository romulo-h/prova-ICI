using ICI.ProvaCandidato.Dados;
using ICI.ProvaCandidato.Negocio;
using ICI.ProvaCandidato.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System;
using System.Linq;

namespace ICI.ProvaCandidato.Web.Controllers
{
    public class TagController : Controller
    {
        private readonly Context ctx;
        public TagController()
        {
            ctx = new Context();
        }
        public IActionResult Index()
        {
            ListarTags();
            return View();
        }
        public IActionResult CadastrarTag()
        {
            return View(new Tag());
        }

        public IActionResult ListarTags()
        {
            try
            {
                ViewBag.LstTags = ctx.Tag.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return PartialView();
        }

        [HttpPost]
        public IActionResult SalvarTag(Tag tag)
        {
            try
            {
                if (tag.Id > 0)
                {
                    Tag tagExistente = ctx.Tag.Find(tag.Id);
                    if (tagExistente != null)
                    {
                        tagExistente.Descricao = tag.Descricao;
                        ctx.SaveChanges();
                    }
                }
                else
                {
                    ctx.Tag.Add(tag);
                    ctx.SaveChanges();
                }

                return Json(true);
            }
            catch (Exception)
            {
                return Json(false);
            }
        }

        public IActionResult EditarTag(int Id)
        {
            Tag tag = ctx.Tag.Where(x => x.Id == Id).FirstOrDefault();
            if (tag != null)
            {
                return View("CadastrarTag", tag);
            }
            return RedirectToAction("CadastroTag");

        }
        public IActionResult PesquisarTag(string desc)
        {
            ViewBag.LstTags = ctx.Tag.Where(x => desc.Contains(x.Descricao)).ToList();
            return View("ListarTags");
        }

        [HttpPost]
        public IActionResult ExcluirTag(int Id)
        {
            try
            {
                Tag tag = ctx.Tag.Where(x => x.Id == Id).FirstOrDefault();
                if (tag != null)
                {
                    ctx.Tag.Remove(tag);
                    ctx.SaveChanges();

                    return Json(new
                    {
                        retorno = true
                    });
                }
                else
                {
                    return Json(new
                    {
                        retorno = false,
                        mensagem = "Erro ao excluir! Tag não encontrada."
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    retorno = false,
                    mensagem = "Erro ao excluir! " + ex.Message
                });
            }
        }
    }
}

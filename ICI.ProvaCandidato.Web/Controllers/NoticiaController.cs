using ICI.ProvaCandidato.Dados;
using ICI.ProvaCandidato.Negocio;
using ICI.ProvaCandidato.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ICI.ProvaCandidato.Web.Controllers
{
    public class NoticiaController : Controller
    {
        private readonly Context ctx;
        public NoticiaController()
        {
            ctx = new Context();
        }
        public IActionResult Index()
        {
            ListarNoticia();
            return View();
        }

        public IActionResult ListarNoticia()
        {
            List<Noticia> noticias = ctx.Noticia.ToList();
            List<NoticiaModel> lstNoticia = new List<NoticiaModel>();
            Usuario usuario = ctx.Usuario.FirstOrDefault();
            if (noticias.Count > 0)
            {
                foreach (var item in noticias)
                {
                    lstNoticia.Add(new NoticiaModel()
                    {
                        NmUsuario = usuario.Nome,
                        Texto = item.Texto,
                        Titulo = item.Titulo,
                        Id = item.Id
                    });
                }
            }
            ViewBag.LstNoticia = lstNoticia;

            return PartialView();
        }

        public IActionResult CadastrarNoticia()
        {
            if (ViewBag.LstTag != null)
            {
                return View(new Noticia());
            }
            else
            {

                List<Tag> tagsBD = ctx.Tag.ToList();
                var tags = new List<Tag>();
                if (tagsBD.Count > 0)
                {
                    foreach (var item in tagsBD)
                    {
                        tags.Add(new Tag() { Id = item.Id, Descricao = item.Descricao });
                    }
                }
                ViewBag.LstTag = tags;
                return View(new Noticia());
            }
        }

        [HttpPost]
        public IActionResult SalvarNoticia(Noticia noticia)
        {
            try
            {
                Usuario usuario = ctx.Usuario.FirstOrDefault();

                if (noticia.Id > 0)
                {
                    Noticia noticiaExistente = ctx.Noticia.Find(noticia.Id);
                    if (noticiaExistente != null)
                    {
                        noticiaExistente.Titulo = noticia.Titulo;
                        noticiaExistente.Texto = noticia.Texto;
                        noticiaExistente.UsuarioId = usuario.Id;

                    }
                    ctx.SaveChanges();
                    return Json(true);
                }
                else
                {
                    noticia.UsuarioId = usuario.Id;
                    ctx.Noticia.Add(noticia);
                    ctx.SaveChanges();

                    if (noticia.Tags.Count > 0)
                    {
                        foreach (var item in noticia.Tags)
                        {
                            var noticiaNova = new NoticiaTag()
                            {
                                NoticiaId = noticia.Id,
                                TagId = item.Value

                            };

                            ctx.NoticiaTag.Add(noticiaNova);
                        }
                        ctx.SaveChanges();

                    }
                    return Json(true);
                }
            }
            catch (Exception ex)
            {
                return Json(false);
            }

        }

        public IActionResult EditarNoticia(int Id)
        {
            Noticia noticia = ctx.Noticia.Where(x => x.Id == Id).FirstOrDefault();
            List<Tag> tags = new List<Tag>();
            if (noticia != null)
            {
                var noticiaTags = ctx.NoticiaTag.Where(x => x.NoticiaId == noticia.Id).Select(y => y.TagId).ToList();
                if (noticiaTags.Count > 0)
                {
                    tags.AddRange(ctx.Tag.Where(x => noticiaTags.Contains(x.Id)).ToList());
                    noticia.TagsSalvas = tags;
                }
                ViewBag.LstTag = tags;
                return View("CadastrarNoticia", noticia);
            }
            return RedirectToAction("CadastroNoticia");

        }

        [HttpPost]
        public IActionResult ExcluirNoticia(int Id)
        {
            try
            {
                Noticia noticia = ctx.Noticia.Where(x => x.Id == Id).FirstOrDefault();
                if (noticia == null)
                {
                    return Json(false);
                }
                else
                {
                    List<NoticiaTag> tags = ctx.NoticiaTag.Where(x => x.NoticiaId == noticia.Id).ToList();
                    if (tags.Count > 0)
                    {
                        ctx.NoticiaTag.RemoveRange(tags);
                    }
                    ctx.Noticia.Remove(noticia);
                    ctx.SaveChanges();
                    return Json(true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

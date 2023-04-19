

function IsNull(string) {
    if (string === null || string === undefined || string === "" || string === '') {
        return true;
    }
    return false;
}
function exibirMensagemErro(mensagem) {
    var divErro = document.getElementById("erro");
    divErro.innerHTML = mensagem;
    divErro.style.display = "block";
}
function CadastrarTag() {
    let tag = {};
    $('#Tag').serializeArray().map(function (x) { tag[x.name] = x.value; });

    if (IsNull(tag.Descricao)) {
        exibirMensagemErro('Adicione o Descrição da Tag!');
        return false;
    }


    if (tag.Id > 0) {

        $.post('/Tag/SalvarTag/', { tag: tag }, function (data) {
            if (data) {
                window.location.href = '/Tag/Index';
            } else {
                exibirMensagemErro('Houve um erro ao realizar a edição da tag.')
            }
        });
    }
    else {
        $.post('/Tag/SalvarTag/', { tag: tag }, function (data) {
            if (data) {
                window.location.href = '/Tag/Index';
            } else {
                exibirMensagemErro('Houve um erro ao realizar o cadastro do tag.')
            }
        });
    }

}
function EditarTag(IdTag) {
    window.location.href = '/Tag/EditarTag/?Id=' + IdTag;
}

function PesquisarTag() {
    var desc = document.getElementById("Descricao").value;
    if (desc != null || desc != "") {
        window.location.href = '/Tag/PesquisarTag/?desc=' + desc.toString();

    }
}

function LimparPesquisa() {
    window.location.href = '/Tag/Index';
}

function ExcluirTag(IdTag) {
    $.post('/Tag/ExcluirTag/', { Id: IdTag }, function (data) {
        if (data.retorno) {
            window.location.href = '/Tag/Index';
        } else {
            exibirMensagemErro(data.mensagem)
        }
    })
}

function CadastrarNoticia() {
    debugger
    let noticia = {};
    $('#Noticia').serializeArray().map(function (x) { noticia[x.name] = x.value; });
    var lstTag = $('[data-filtro=Tag]:visible') ? $("#IdTag").val() : null;
    noticia.Tags = lstTag;
    if (IsNull(noticia.Titulo)) {
        exibirMensagemErro('Adicione um Título a notícia!');
        return false;
    }
    if (IsNull(noticia.Texto)) {
        exibirMensagemErro('Adicione um Texto a notícia!');
        return false;
    }

    if (noticia.Id > 0) {

        $.post('/Noticia/SalvarNoticia/', { noticia: noticia }, function (data) {
            if (data) {
                exibirMensagemErro('Edição realizada com sucesso.');
                window.location.href = '/Noticia/Index';
            } else {
                exibirMensagemErro('Houve um erro ao realizar a edição da noticia.')
            }
        });
    }
    else {
        $.post('/Noticia/SalvarNoticia/', { noticia: noticia }, function (data) {
            if (data) {
                window.location.href = '/Noticia/Index';
            } else {
                exibirMensagemErro('Houve um erro ao realizar o cadastro da noticia')
            }
        });
    }

}
function EditarNoticia(IdNoticia) {
    window.location.href = '/Noticia/EditarNoticia/?Id=' + IdNoticia;
}

function ExcluirNoticia(IdNoticia) {
    $.post('/Noticia/ExcluirNoticia/', { Id: IdNoticia }, function (data) {
        if (data) {
            window.location.href = '/Noticia/Index';
        } else {
            exibirMensagemErro('Houve um erro ao excluir a noticia.')
        }
    })
}

function LimparNoticia() {
    var formulario = document.getElementById("Noticia").value;
    formulario.reset();
}
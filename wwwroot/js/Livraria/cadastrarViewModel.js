var vm = {
    autor: ko.observable(""),
    titulo: ko.observable(""),

    cadastrarLivroClick: function () {
        cadastrarLivro(vm.titulo(), vm.autor())
    }
}

function cadastrarLivro(titulo, autor) {
    $.ajax({
        type: "POST",
        url: baseUrl + 'Api/Cadastrar',
        dataType: "json",
        data: {
            titulo: titulo,
            autor: autor
        },
        success: function () {
            window.location.href = '/Livraria/Listar';
        },
        error: function (request, error) {
            alert("Request: " + JSON.stringify(request));
        }
    });
}

$(document).ready(function () {
    ko.applyBindings(vm);
});
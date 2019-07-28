var vm = {
    autor: ko.observable(""),
    titulo: ko.observable(""),

    alterarLivroClick: function () {
        alterarLivro(vm.titulo(), vm.autor())
    }
}

function alterarLivro(titulo, autor) {
    $.ajax({
        type: "PATCH",
        url: baseUrl + 'Api/Alterar',
        dataType: "json",
        data: {
            id: id,
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

function carregarLivro() {
    $.ajax({
        type: "GET",
        dataType: "json",
        data: { id: id },
        url: baseUrl + 'Api/Carregar',
        success: function (data) {
            vm.autor(data.autor);
            vm.titulo(data.titulo);
        },
        error: function (request, error) {
            alert("Request: " + JSON.stringify(request));
        }
    });
}

$(document).ready(function () {
    ko.applyBindings(vm);
    carregarLivro();
});
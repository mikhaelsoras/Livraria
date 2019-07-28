var vm = {
    livros: ko.observableArray([]),

    removerLivroClick: function (livro) {
        excluirLivro(livro.id);
    },
    editarLivroClick: function (livro) {

    }
}

function excluirLivro(livroId) {
    $.ajax({
        type: "DELETE",
        url: baseUrl + 'Api/Remover',
        dataType: "json",
        data: {
            id: livroId
        },
        success: function () {
            carregarLivros();
        },
        error: function (request, error) {
            alert("Request: " + JSON.stringify(request));
        }
    });
}

function carregarLivros() {
    vm.livros([]);
    $.ajax({
        type: "GET",
        dataType: "json",
        url: baseUrl + 'Api/Carregar',
        success: function (data) {
            vm.livros(data);            
        },
        error: function (request, error) {
            alert("Request: " + JSON.stringify(request));
        }
    });
}

$(document).ready(function () {
    ko.applyBindings(vm);
    carregarLivros();
});
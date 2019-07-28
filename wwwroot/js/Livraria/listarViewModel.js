var vm = {
    livros: ko.observableArray([])
}

$(document).ready(function () {
    ko.applyBindings(vm);
});
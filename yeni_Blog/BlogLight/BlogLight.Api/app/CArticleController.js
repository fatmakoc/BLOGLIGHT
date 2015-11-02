var app = angular.module('MyApp');

app.controller("CArticleCtrl", ['$scope', '$routeParams', '$resource', function ($scope, $routeParams, $resource) {

    var kategYazilari = $resource('api/CArticle/:categId', null);

    kategYazilari.query({ categId: $routeParams.categId }, function (result) {
        $scope.gelenyazilar = result;
    });




    
}]);



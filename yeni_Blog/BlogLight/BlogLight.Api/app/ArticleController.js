var app = angular.module('MyApp');

app.controller("ArticleCtrl", ['$scope', '$resource', function ($scope, $resource) {

    var YazıService = $resource('api/Article/:ArticId', { ArticId: '@ArticId' });

     YazıService.query(function (result) {
         $scope.yazilar = result;
    });


}]);
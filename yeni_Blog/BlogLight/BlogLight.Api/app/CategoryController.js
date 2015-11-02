var app = angular.module('MyApp');

app.controller("CategoryCtrl", ['$scope', '$resource', function ($scope, $resource) {

    var CategoryService = $resource('api/Category/:CategId', { CategId: '@CategId' });

    CategoryService.query(function (Kresult) {
        $scope.kategoriler = Kresult;
    });


}]);
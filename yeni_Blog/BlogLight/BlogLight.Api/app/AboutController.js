var app = angular.module('MyApp');

app.controller("AboutCtrl", ['$scope', '$resource', function ($scope, $resource) {

    var hakkımda = $resource('api/About/:AboutId', { AboutId: '@AboutId' });

    hakkımda.query(function (result) {
        $scope.bilgi = result;
    });


}]);
var app = angular.module('MyApp');

app.controller('ContactCtrl', function ($scope) {
    $scope.header = "İLETİŞİM",
    $scope.sosyal = "http://facebook.com/someone",
    $scope.mail = "biri@someone.com",
    $scope.mesaj = "Mesaj"
});
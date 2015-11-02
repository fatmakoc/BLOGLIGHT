var app = angular.module('MyApp');

app.controller("GirisCtrl", ['$scope', '$routeParams', '$resource', function ($scope, $routeParams, $resource) {

    var girisi = $resource('api/Giris/:GirisId', null, {
        save: { method: 'GET' }
    });
    
   
   girisi.query(function (result) {
        $scope.uyeler = result;
    });


    $scope.AdminVarMi = function () {

        girisi.save({ adres: $scope.email_Giris, parolasi: $scope.sifre_Giris }, function (sonuc) {
            $scope.gelendeger = sonuc;
        });

        if ($scope.gelendeger !=null )
            alert('Admin başarılı');
        else
            alert('Böyle bir admin yok');

    }


}]);




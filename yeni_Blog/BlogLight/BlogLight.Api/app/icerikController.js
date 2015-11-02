var app = angular.module('MyApp');

app.controller("icerikCtrl", ['$scope', '$routeParams', '$resource', function ($scope, $routeParams, $resource) {
  
    var icerigi = $resource('api/icerik/:icerikId', null, {
        save: { method: 'POST' }
    });


 

    //İCERİGİ GETİRİYOR
    icerigi.query({ icerikId: $routeParams.icerikId }, function (result) {
        $scope.gelenyazi = result;
    });
    
    ////YORUMLARI ÇEKME

    //icerigi.query({ icerikId: $routeParams.icerikId }, function (gelenler) {
    //    $scope.gelenyorumlar = gelenler;
    //});


  
    //YORUM EKLEME OLAYI
    $scope.YorumEkle = function () {
      
        $scope.yeniYorum = new icerigi();
        $scope.yeniYorum.IdWriting_Comment =$routeParams.icerikId;
        $scope.yeniYorum.Mail_Comment=$scope.vMail;
        $scope.yeniYorum.Text_Comment=$scope.vYorum;

        if (icerigi.save($scope.yeniYorum) == true) {
            alert('Yorumunuz başarıyla alınmıştır');
        }

       };
      
    




}]);




var app = angular.module('MyApp', ['ngRoute', 'ngResource']);

app.config(function ($routeProvider) {
    $routeProvider
        .when('/Category', {
            templateUrl: 'Category.html',
            controller: 'CategoryCtrl'
        })
        .when('/About', {
            templateUrl: 'About.html',
            controller: 'AboutCtrl'
        })
        .when('/Contact', {
            templateUrl: 'Contact.html',
            controller: 'ContactCtrl'
        })
        .when('/Article', {
            templateUrl: 'Article.html',
            controller: 'ArticleCtrl'
        })
      .when('/icerik/:icerikId', {
          templateUrl: 'icerik.html',
          controller: 'icerikCtrl'
      })
        .when('/Giris', {
            templateUrl: 'Giris.html',
            controller: 'GirisCtrl'

        })
        .when('/CArticle/:categId', {
            templateUrl: 'CArticle.html',
            controller: 'CArticleCtrl'
        })
    .otherwise({
        templateUrl: 'Article.html',
        controller: 'ArticleCtrl'
    });

});

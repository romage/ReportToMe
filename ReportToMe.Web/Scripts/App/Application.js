/// <reference path="_references.js" />
/// <reference path="https://cdnjs.cloudflare.com/ajax/libs/angular.js/1.3.11/angular-route.js" />
/// <reference path="../Libs/angular-resource.js" />

var reportToMe = angular.module('reportToMe', ['ngRoute', 'ui.bootstrap']);

reportToMe.directive('meeting', function () {
    return {
        restrict: 'E',
        templateUrl: "/Directives/Meeting.html"
    }
});

reportToMe.config(function ($routeProvider) {
    console.log("reportToMe.config route entered.");

    $routeProvider
        .when("/", {
            templateUrl: "Home/IndexNg",
            controller: "ContentController"
        })
        .when("/Meetings", {
            templateUrl: "Meeting/IndexNg",
            controller: "MeetingController"
        })
        .when("/Meetings/Details/:id", {
            templateUrl: "/NgViews/MeetingDetails.html",
            controller: "MeetingDetailController"
        })
       
});




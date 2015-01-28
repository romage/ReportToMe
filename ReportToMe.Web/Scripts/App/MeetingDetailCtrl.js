/// <reference path="_references.js" />
/// <reference path="https://cdnjs.cloudflare.com/ajax/libs/angular.js/1.3.11/angular-route.js" />
/// <reference path="../Libs/angular-resource.js" />

reportToMe.controller("MeetingDetailController", function ($scope, $routeParams, $http, MeetingDetailService) {
    var id;
    if ($routeParams)
    {
        id = $routeParams.id;
        console.log(id);
        //var result = MeetingDetailService.getMeeting(id);
        //console.log(result);
        $http.post('/Meeting/DetailsJson', { id: id })
           .success(function (data, status, headers, config) {
               console.log(data);
               ret = 'yay';
           })
           .error(function (data, status, headers, config) {
               console.log(data);
               console.log('isBoo');
               ret = 'boo';
           });
    }

   
});

reportToMe.service("MeetingDetailService", function ($http) {

    this.getMeeting = function(id) {
        /// <summary>gets the meetings for </summary>
        /// <param name="id"  type="Number">The id of the meeting.</param>
        /// <returns type="Number">The area.</returns>
        var ret;
        $http.post('/Meeting/DetailsJson', {id: id})
            .success(function (data, status, headers, config) {
                ret = 'yay';
            })
            .error(function (data, status, headers, config) {
                console.log(status);
                console.log('isBoo');
                ret = 'boo';
            });
        return ret;
    }
});


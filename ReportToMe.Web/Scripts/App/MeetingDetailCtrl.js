/// <reference path="_references.js" />
/// <reference path="https://cdnjs.cloudflare.com/ajax/libs/angular.js/1.3.11/angular-route.js" />
/// <reference path="../Libs/angular-resource.js" />

console.log("meetingDetailsCtrl");

reportToMe.controller("MeetingDetailController", function ($scope, $routeParams, $http, MeetingDetailService) {
    var id;
    if ($routeParams)
    {
        id = $routeParams.id;
        console.log(id);
        
        MeetingDetailService.getMeeting(id)
           .success(function (data, status, headers, config) {
               $scope.data = data;
           })
           .error(function (data, status, headers, config) {
               $scope.data = data;
           }).then(function () {
               console.log($scope.data);
               console.log("not sure what, if anything, to do here.");
           });
    }

   
    $scope.save = function () {
        var du = this.departmentUpdate;
        var mp = this.meetingProject;
        var field = "#ducontent-" + mp.id + '-' + du.department.id + '-' + du.id;
        console.log($(field).html());
        var obj = { meetingProjectId: mp.id, departmentId: du.department.id, departmentUpdateId: du.id, newContent: $(field).html() };
        MeetingDetailService.saveContent(obj)
            .then(function (data, status, headers, config) {
                console.log(data);
            })
    }
    $scope.cancel = function () {
        console.log("cancel clicked");
       
    }

});

reportToMe.service("MeetingDetailService", function ($http) {

    this.getMeeting = function(id) {
        /// <summary>gets the meetings for </summary>
        /// <param name="id"  type="Number">The id of the meeting.</param>
        /// <returns type="Number">The area.</returns>
       return  $http.post('/Meeting/Details', {id: id})
    }

    this.saveContent = function (obj) {
        return $http.post('/Meeting/UpdateContent', obj);
    };
});

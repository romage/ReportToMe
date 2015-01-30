reportToMe.controller("MeetingController", function ($scope, $routeParams, MeetingService) {
   
    console.log("MeetingService entered");
   
    MeetingService.getMeetingList()
        .success(function (data, status, headers, config) {
            console.log(data);
            $scope.meetings = data;
        })
        .error(function (data, status, headers, config) {
            $scope.meetings = data;
        });

   
});


reportToMe.service("MeetingService", function ($http) {
    this.getMeetingList = function() {
        return $http.post("/Meeting/GetMeetings");
    }

})

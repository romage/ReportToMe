reportToMe.controller("MeetingController", function ($scope, $routeParams) {
    var preloaded =  JSON.parse($("#preloaded").val());
    $scope.preloaded =preloaded;
    console.log(preloaded);
});
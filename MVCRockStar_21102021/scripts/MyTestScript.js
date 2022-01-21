var app = angular.module('myApp', []);
app.controller('myCtrl', function ($scope) {

    //$scope.name = "Usha";
    $scope.getAlert=function()
    {
        alert($scope.userName);
        $scope.result = "Welcome to OnBoard " + $scope.userName + ", I am " + $scope.dropDownSelect;
    }
})
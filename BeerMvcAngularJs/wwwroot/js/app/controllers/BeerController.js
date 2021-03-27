angular.module("BeerMvcAngularJs.BeerController", [])
    .controller("BeerController", ["$scope", "$http", function ($scope, $http) {
        $scope.model = {};
        $scope.states = {
            showBeerForm: false
        };
        $scope.new = {
            beer: {}
        };

        $http.get("/Beer/IndexViewModel").then(function(response) {
            $scope.model = response.data;
        });

        $scope.toggleAddBeerForm = function() {
            $scope.states.showBeerForm = !$scope.states.showBeerForm;
        }
    }]);
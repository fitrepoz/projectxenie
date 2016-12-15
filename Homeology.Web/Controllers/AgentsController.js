(function() {
    var AgentsController = function ($scope, $http) {
        var agents = function(serviceResp) {
            $scope.Agent = serviceResp.data;
        };
        var errorDetails = function(serviceResp) {
            $scope.Error - "Something went wrong";
        };

        $http.get("http://localhost:51351/api/agents")
            .then(agents, errorDetails);
        $scope.Title = "Agent Details Page";
    };
    app.controller("AgentsController", AgentsController);
}());

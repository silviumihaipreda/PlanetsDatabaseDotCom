var planetsDatabaseDotComController = ($http, $scope) => {

    $http.get('http://localhost/PlanetsDatabaseDotCom/planets').success((data) => {
        $scope.planets = data;
    });
}
planetsDatabaseDotComController.$inject = ['$http', '$scope'];
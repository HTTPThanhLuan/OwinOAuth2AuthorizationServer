'use strict';
app.controller('homeController', ['$scope', 'authService', function ($scope, authService) {

    $scope.login = function () {

        authService.login($scope.loginData).then(function (response) {

            $location.path('/orders');

        },
            function (err) {
                $scope.message = err.error_description;
            });
    };

    $scope.Initial = function () {
        var code = $scope.getParameterByName('code');
        if (code) {
            $scope.Set(code);
        }
    }

    $scope.Set = function (code) {
        authService.GetAcessTokenFromCode(code);
    };
    $scope.getParameterByName = function (name, url) {
        if (!url) url = window.location.href;
        name = name.replace(/[\[\]]/g, "\\$&");
        var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
            results = regex.exec(url);
        if (!results) return null;
        if (!results[2]) return '';
        return decodeURIComponent(results[2].replace(/\+/g, " "));
    }
    $scope.Initial();
}]);
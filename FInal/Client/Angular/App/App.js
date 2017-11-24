var app = angular.module('app', []);


app.controller('main', function ($scope, $http) {
    $scope.something = "Darko Gele";
    
    $scope.api = function () {
        $scope.greeting = 'Hello Noob  ' + $scope.username + '!';
    };
    //preku web api ziame do wcf string YEY
    $http.get("http://localhost/WebClient/api/test/get")
        .then(function (response) {
            $scope.myWelcome = response.data;
            $scope.statuscode = response.status;
        });

   //post za sobiranje
    $scope.soberi = function () {
        var request = $http({
            method: 'POST',
            url: "http://localhost/WebClient/api/test/plus",
            params: {
                value1: $scope.soberi1,
                value2: $scope.soberi2               
             }
        }).then(
            function (response) {
                $scope.plus = response.data;
            },
            function (response) {
                console.log("padna na sobiranje");
        });
    }

    //odzemanje 
    $scope.odzemi = function (odzimanje1, odzimanje2, minus) {
        var request = $http({
            method: 'POST',
            url: "http://localhost/WebClient/api/test/minus",
            params: {
                odzimanje1: odzimanje1,
                odzimanje2: odzimanje2
            }
        }).then(
            function (response) {
                $scope.minus = response.data;
            },
            function (response) {
                console.log("padna na minusiranje ");
            });
    }

    //mnozenje
    $scope.mnozi = function (Mnozi1, Mnozi2, pomnozi) {
        var request = $http({
            method: 'POST',
            url: "http://localhost/WebClient/api/test/mnozi",
            params: {
                Mnozi1: Mnozi1,
                Mnozi2: Mnozi2
            }
        }).then(
            function (response) {
                $scope.pomnozi = response.data;
            },
            function (response) {
                console.log("padna na mnozenje ");
            });
    }

    //delenje
    $scope.deli = function () {
        var request = $http({
            method: 'POST',
            url: "http://localhost/WebClient/api/test/deli",
            params: {
                value1:$scope.deli1,
                value2:$scope.deli2
            }
        }).then(
            function (response) {
                $scope.podeleno = response.data;
            },
            function (response) {
                console.log("padna na mnozenje ");
            });
    }

    $scope.green = {
        //"color": "Gray",
        "text-alignn": "center",
        "color": "white",
        "background-color": "coral",
        "font-size": "18px",
        "border": "solid 1px black"
        //"padding": "50px"
    }
        
});
 //$scope.value1 = $scope.value1;


    //stavame string
    //$http.post('http://localhost/WebClient/api/test/get', data, config)
    //    .success(function (data, status, headers, config) {
    //        $scope.PostDataResponse = data;
    //    });
    //    .error(function (data, status, header, config) {
    //        $scope.ResponseDetails = "Data: " + data +
    //            "<hr />status: " + status +
    //            "<hr />headers: " + header +
    //            "<hr />config: " + config;
    //    });


//$http.get("welcome.htm")
//    .then(function (response) {
//        $scope.myWelcome = response.data;
//    });


 //$scope.add = $http.post("http://localhost/WebClient/api/test/get")
    //    .then(function (response) {
    //        $scope.value1 = response.data;
    //        $scope.value2 = response.data;
    //    })

//$scope.get = $http.get('http://localhost/WebClient/api/get'), success(function (response) {
//    $scope.success = response;
//});

//$http({
//    method: 'GET',
//    url: 'http://localhost/WebClient/api/get'
//})
//    .then(function) {
//    $scope.Raboti = responce.data;
//    $log.info(responce);
//}, function (reason) {
//    $scope.error = reason.data;
//    $log.info(reason);
//}

 // $http.get('http://localhost/WebClient/api/test/get');
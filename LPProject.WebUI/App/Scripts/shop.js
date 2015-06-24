var app = angular.module("app", []);

app.factory("Shops", function () {
    return [];
});

app.controller("ShopController", function ($scope, $http) {
    $scope.getAllShop = function () {
        $http.get("/api/shops")
            .success(function (data) {
                $scope.shops = data;
            });
    };
    $scope.addShop = function (shop) {
        $http.post("/api/shops", shop)
            .success(function () {
                $scope.getAllShop();
            })
            .error(function () {
                console.log();
            });
    };

    $scope.saveShop = function (shop) {
        $http.put("/api/shops", shop)
        .success(function (data, status) {
        }).error(function () {
            $scope.getAllShop();
        });
    };
    $scope.deleteShop = function (shop) {
        $http.delete("/api/shops/" + shop.Id)
            .success(function () {
                $scope.getAllShop();
            })
            .error(function (data, status) {
                console.log(status);
            });
    };

    $scope.getGoods = function (shopid) {
        
        $http.get("/api/shops/GetGoods/" + shopid)
            .success(function (data) {
                $scope.goodses = data;
            })
            .error(function () {
                console.log();
            });
        $scope.goods.shopId = shopid;
    };
    $scope.addGoods = function (goods) {
        $http.post("/api/goods", goods)
            .success(function () {
                goods.name = "";
                goods.description = "";
                $scope.getGoods(goods.shopid);
            })
            .error(function () {
                console.log();
            });
    };


    $scope.deleteGoods = function(goods) {
        $http.delete("/api/goods/" + goods.Id)
            .success(function() {
                $scope.getGoods($scope.goods.shopId);
            })
            .error(function(data, status) {
                console.log(status);
            });
    };
    $scope.getAllShop();
});
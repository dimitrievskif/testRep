// Variables.
var app = angular.module("umbraco");

// Associate directive.
app.directive("formulateValidationRegex", directive);

// Directive.
function directive(formulateDirectives) {
    return {
        restrict: "E",
        replace: true,
        template: formulateDirectives.get(
            "validationKinds/validationRegex/validationRegex.html"),
        scope: {
            data: "="
        }
    };
}
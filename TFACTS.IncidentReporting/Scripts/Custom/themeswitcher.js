$(document).ready(function ()
{
    if (localStorage.theme)
    {
        updateStyleSheet(localStorage.theme,localStorage.themeTelerik)
    }
});
function updateStyleSheet(filename,telerik) {

    // Create the CSS file name:

    newstylesheet = "/content/css/" + filename + "/bootstrap.css";
    //newstylesheet = "@Url.Content('~/Content/css/" + filename + "/bootstrap.css')";
    telerikBaseURI = "http://cdn.kendostatic.com/2013.3.1324/styles/kendo." + telerik + ".min.css"
    //$("body").data("theme", filename)
    //$.cookie("theme",filename)
    localStorage.setItem("theme", filename);
    localStorage.setItem("themeTelerik", telerik);
    //content/css/amelia/bootstrap.css
    //Default CSS = http://cdn.kendostatic.com/2013.3 1324/styles/kendo.bootstrap.min.css
    // Does the <link> tag (with id:dynamic_css) exist?
    // If not, we need to create it.

    if ($("#themeCSS").length == 0) {

        // The next line will add the
        // <link> tag between the
        // <head> tags.

        $("head").append("<link>")

        // The next line will select the
        // <link> element you just added.

        css = $("head").children(":last");

        // The next line will set the
        // attributes of the elements
        // to make it load the CSS file.

        css.attr({
            id: "themeCSS",
            rel: "stylesheet",
            type: "text/css",
            href: newstylesheet
        });

        // If the <link> element already exists, we
        // simply need to change the value of "href".

    }
    else
    {
        $("#themeCSS").attr("href", newstylesheet);
    }

    if ($("#themeTelerik").length == 0) {

        // The next line will add the
        // <link> tag between the
        // <head> tags.

        $("head").append("<link>")

        // The next line will select the
        // <link> element you just added.

        css = $("head").children(":last");

        // The next line will set the
        // attributes of the elements
        // to make it load the CSS file.

        css.attr({
            id: "themeCSS",
            rel: "stylesheet",
            type: "text/css",
            href: telerikBaseURI
        });

        // If the <link> element already exists, we
        // simply need to change the value of "href".

    }
    else {
        $("#themeTelerik").attr("href", telerikBaseURI);
    }
}
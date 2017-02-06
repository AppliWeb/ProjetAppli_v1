/*****************************************************************
 * Auteur : Serge L'HOSTIS
 * Date   : 2016-04-30
 * Description : Construction d'un menu principal d'un site Web
 * References : 
 *      bootstrap.css
 *      bootstrap.js
 *      jquery.js
 *      fichier JSON  contenant les données du menu
 *****************************************************************/
var Menu = {}; // Espace de nom pour le menu

/**
 * Construit le menu principal
 * @param {string} filename : nom du fichier JSON
 * @param {string} id : identifiant du container du menu : #id, elem, .cssClass
  */
Menu.load = function(filename, id) {
    var $menu = $(id);
    $menu.attr({"class":"navbar navbar-default","role": "navigation"});
    $container = $('<div class="container-fluid">').appendTo($menu);
    $.getJSON(filename, function (json) {
        for (var key in json) {
            if (key === 'title') {
                Menu.title($container, json, 'title');
            } else if (key === 'data') {
                $ul = Menu.mainMenu($container);
                for (var subKey in json[key]) {
                    var value = json[key][subKey];
                    if (typeof (value) === 'string') {
                        Menu.singleMenu($ul, subKey, value);
                    } else {
                        $subUL = Menu.dropdownMenu($ul, subKey);
                        Menu.subMenu($subUL, value);
                    }
                }
            }
        }
    });
};

/**
 * Constuit un menu sans sous-menu 
 * @param {jQuery} $container 
 * @param {string} label : libellé du menu
 * @param {string} url : adresse du fichier
  */
Menu.singleMenu = function($container, label, url) {
    $('<li class="active">' 
           + '<a href="' + url + '">' 
           + '<span class="glyphicon glyphicon-home"></span>'
           + label + '</a></li>').appendTo($container);
};

/**
 * Construit un container de sous-menu
 * @param {jQuery} $container : container du sous-menu (le menu principal)
 * @param {string} label : libellé du menu
 * @returns {jQuery} : le sous-menu
 */
Menu.dropdownMenu = function($container, label) {
    var $dropdown = $('<li class="dropdown">').appendTo($container);
    $('<a href="?" class="dropdown-toggle" data-toggle="dropdown" '
        + 'role="button" aria-expanded="false">'
        + label + '<span class="caret"></span></a>').appendTo($dropdown);
    var $ul = $('<ul class="dropdown-menu" role="menu">').appendTo($dropdown);
    return $ul;
};

/**
 * Construit un sous-menu
 * @param {jQuery} $container : container du sous-menu (le dropdown)
 * @param {JSON} json : tableau JSON représentant le sous-menu
  */
Menu.subMenu = function($container, json) {
    for (var key in json) {
        var value = json[key];
        if (key.indexOf('divider') === -1)
            $('<li><a href="'+ value +'">'+ key +'</a></li>')
                .appendTo($container);
        else
            $('<li class="divider"></li>').appendTo($container);
    }
};

/**
 * Construit l'onglet à gauche du menu
 * @param {jQuery} $container : le menu
 * @param {JSON} json : le tableau JSON contenant le menu
 * @param {string} key : la clé du tableau JSON concernant le titre
  */
Menu.title = function($container, json, key) {
    var subJson = json[key];
    var $title = $('<div class="navbar-header">').appendTo($container);
    for (var subkey in subJson) {
        var value = subJson[subkey].trim();
        $('<a class="navbar-brand" href="'+ value + '">' + subkey + '</a>')
                .appendTo($title);
        break; // Normalement, il n'y a qu'un titre
    }   
};

/**
 * Construit un élément du menu principal
 * @param {jQuery} $container : container de l'élément du menu principal
 * @returns {jQuery} : un élément du menu principal
 */
Menu.mainMenu = function($container) {
    var $div = $('<div id="navbar" class="navbar-collapse collapse">')
            .appendTo($container);
    var $ul = $('<ul class="nav navbar-nav">').appendTo($div);
    return $ul;
};
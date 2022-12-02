<?php

namespace Config;

// Create a new instance of our RouteCollection class.
$routes = Services::routes();

// Load the system's routing file first, so that the app and ENVIRONMENT
// can override as needed.
if (is_file(SYSTEMPATH . 'Config/Routes.php')) {
    require SYSTEMPATH . 'Config/Routes.php';
}

/*
 * --------------------------------------------------------------------
 * Router Setup
 * --------------------------------------------------------------------
 */
$routes->setDefaultNamespace('App\Controllers');
$routes->setDefaultController('Site');
$routes->setDefaultMethod('index');
$routes->setTranslateURIDashes(false);
$routes->set404Override();
// The Auto Routing (Legacy) is very dangerous. It is easy to create vulnerable apps
// where controller filters or CSRF protection are bypassed.
// If you don't want to define all routes, please use the Auto Routing (Improved).
// Set `$autoRoutesImproved` to true in `app/Config/Feature.php` and set the following to true.
// $routes->setAutoRoute(false);

/*
 * --------------------------------------------------------------------
 * Route Definitions
 * --------------------------------------------------------------------
 */

// We get a performance increase by specifying the default
// route since we don't have to scan directories.
$routes->get('/', 'Site::index');
$routes->get('/home', 'Site::/home');
$routes->get('/about', 'Site::view/about');
$routes->get('/products', 'Site::view/products');
$routes->get('/contact', 'Site::view/contact');

$routes->get('/listClients', 'Client::listClients');

//Rotas admin
$routes->get('/admin', 'Admin\Admin::index');
$routes->get('/admin/login', 'Admin\Admin::login');
$routes->get('/admin/logout', 'Admin\Admin::logout');

$routes->add('/admin/validateLogin', 'Admin\User::validateLogin');

// Clientes
$routes->add('/admin/listClients', 'Admin\Client::listClients');
$routes->add('/admin/insertClient', 'Admin\Client::insertClient');
$routes->add('/admin/insertClientAction', 'Admin\Client::insertClientAction');
$routes->add('/admin/client/buscar', 'Admin\Client::buscarClient');
$routes->add('/admin/client/buscar-action', 'Admin\Client::buscarClientAction');

$routes->add('admin/updateClient/(:num)','Admin\Client::updateClient/$1');
$routes->add('admin/updateClientAction/(:num)','Admin\Client::updateClientAction/$1');
$routes->add('admin/deleteClient/(:num)','Admin\Client::deleteClient/$1');





/*
 * --------------------------------------------------------------------
 * Additional Routing
 * --------------------------------------------------------------------
 *
 * There will often be times that you need additional routing and you
 * need it to be able to override any defaults in this file. Environment
 * based routes is one such time. require() additional route files here
 * to make that happen.
 *
 * You will have access to the $routes object within that file without
 * needing to reload it.
 */
if (is_file(APPPATH . 'Config/' . ENVIRONMENT . '/Routes.php')) {
    require APPPATH . 'Config/' . ENVIRONMENT . '/Routes.php';
}

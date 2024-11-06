// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function setStatus(status) {
    // Eliminar la clase "selected" de todos los círculos
    document.querySelectorAll('.status-circle').forEach(function(circle) {
        circle.classList.remove('selected');
    });

    // Añadir la clase "selected" al círculo seleccionado
    document.getElementById(status).classList.add('selected');

    // Cambiar el texto de estado
    let statusText = '';
    switch (status) {
        case 'disponible':
            statusText = 'Estado: Disponible';
            break;
        case 'alerta':
            statusText = 'Estado: Alerta';
            break;
        case 'noDisponible':
            statusText = 'Estado: No disponible';
            break;
    }

    document.getElementById('statusText').innerText = statusText;
}
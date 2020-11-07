'use strict'

let map;
let TData;

const labels = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
let labelIndex = 0;
let features = [{ lat: 18.4855, lng: -69.8731 }]

function initMap(obj = null, zoom = 8, TJson = null) {
    if (!!TJson) {
        TData = JSON.parse(TJson)
    } else {
        TData = []
    }
    const RD = { lat: 18.4855, lng: -69.8731 }

    let vista = document.getElementById("vista-mapa")
    setMap(vista, RD, zoom)

    if (obj != null) {
        obj = JSON.parse(obj)

        if (obj.length == 1) {
            setMap(vista, { lat: obj[0].Lat, lng: obj[0].Lng }, zoom)
        }

        obj.forEach((element, index) => {
            let coord = { lat: element.Lat, lng: element.Lng }
            addMarker(coord, map, index, element.Tid)
        });
    }

}

function setMap(container, position, zoom) {
    map = new google.maps.Map(container, {
        center: position,
        zoom: zoom,
    });
}

function addMarker(location, _map, index, title = "") {

    let info
    if (title != "" && TData != null) {
        info = TData.find(i => i.Tid == info)
        console.log(info)
    }

    new google.maps.Marker({
        position: location,
        label: labels[index], //labelIndex++ % labels.length
        title,
        map: _map,
    }).addListener('click', function(e) {
        let fecha = moment(info.Date).format("MMM Do YYYY");
        document.getElementById("modalContentMap").innerHTML = `
    <div>
        <p><b>Nombre: </b>${info.Name}</p>
        <p><b>Fecha: </b>${fecha}</p>
        <p><b>Peso (lb): </b>${info.Weigth} lb</p>
        <p><b>Valor: </b>${info.Value}</p>
        <p><b>Lugar: </b>${info.Place}</p>
        <p><b>Descripción</b><br>${info.Description}</p>
    </div>
    `
        $('#modalDataEvent').modal('show')
    })
}
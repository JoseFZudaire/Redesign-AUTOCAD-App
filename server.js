var http = require('http');
const express = require('express');
const port = 5500;
const app = express();

const fs = require('fs');

// const explode = '(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")(command"_explode""all""")(command"_change""all""""properties""layer""0""")(command"_change""all""""properties""Color""Truecolor""255,255,255""")';
const explode = '(while (setq sset (ssget "X" \'((0 . "INSERT")))) (sssetfirst nil sset) (C:Burst)) (princ) (command"_-purge""B""*""N")';

//Body parser that allows the client 
//to send info of up to 50MB to the server

var bodyParser = require('body-parser');
app.use(bodyParser.json({limit: '50mb'}));
app.use(bodyParser.urlencoded({limit: '50mb', extended: true}));

app.use(express.json());
app.use(express.urlencoded());

//Public route to access files
app.use(express.static('public'));

//Index file
app.get('/', (req,res) => {
    res.sendFile(__dirname + '\\public\\index.html');
});

//Receives the post from the front end
app.post('/formPost', async(req,res)=>{

    var resultadoPrograma = 400; //ERROR
    var archivos = (req.body)["archivos"];
    var comando = (req.body)["comando"];

    console.log(req.body);
    
    var xCoordinate = 0;
    var yCoordinate = 0;
    var command = "";

    var nroProyecto = (archivos[0].split('-'))[0];
    console.log("El nro de proyecto es: ", nroProyecto);

    for(var i = 0; i < archivos.length; i++) {
        var file = archivos[i];
        if(file.slice(-3) == "dwg") {
            var filename = file;
            var filenameReplaced = filename;
            var caracteresAReemplazar = ['á', 'é', 'í', 'ó', 'ú', 'Á', 'É', 'Í', 'Ó', 'Ú'];
            var caracteresNuevos = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];

            //console.log("ASCII character: " + '\u2593');

            for (var c = 0; c < caracteresAReemplazar.length; c++) {
                //console.log("Caracter a reemplazar[c]: ", caracteresAReemplazar[c]);
                //console.log("Caracter nuevo[c]: ", caracteresNuevos[c]);
                filenameReplaced = filenameReplaced.replace(caracteresAReemplazar[c], caracteresNuevos[c], function(err) {
                    //if ( err ) console.log('ERROR en replace: ' + err);
                });
            }

            console.log("Filename replaces is: ", filenameReplaced);
            
            //console.log("Nombre sin reemplazar: ", filename);
            //console.log("Nombre reemplazado: ", filenameReplaced);

            fs.rename(filenameReplaced, filename.replace(), function(err) {
                //if ( err ) console.log('ERROR en rename: ' + err);
            });
            command += '(command"_insert""' + filename + '""scale""1""rotate""0" "' + xCoordinate + ',' + yCoordinate + '" "1""1""1""0")';
            console.log("Command is: ", command)
            xCoordinate += 500;
            if(xCoordinate == 5000) {
                xCoordinate = 0;
                yCoordinate -= 380;
            }

            command += explode;

        }
    }

    // command += explode;
    var commandLine = `(defun c:${comando}() ${command} )`;
    console.log(commandLine);

    resultadoPrograma = createLSPFile(commandLine, nroProyecto);

    return res.status(resultadoPrograma).send({ proyecto: nroProyecto});

});

function createLSPFile(commandLine, nroProyecto) {
    var file = fs.createWriteStream("./public/archivos/" + nroProyecto + ".lsp");

    file.on('error', function(err) {
        console.log("Hubo un error creando el archivo");
        return 400;
    });
    file.write(commandLine);
    file.end();
    return 200;   

}

//Listening on port
app.listen(port,()=>{
    console.log(`Server started at http://localhost:` + port)
});








import logo from './logo.svg';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import './css/slick.css';
import './css/styleHTML.css';
import './css/templatemo-style.css';

function App() {

  var archivos = new Array();
  var nombreProyecto = "error";

  const postInformation = async () => {
    console.log(archivos);

    var comando = document.getElementById('nombreComando').value;

    console.log(comando);

    const response = await fetch("http://localhost:5500/formPost",
        {
          method: 'POST',
          headers: {
            "Content-Type": 'application/json'
          },
          body: JSON.stringify({
            archivos, comando
          })
        });
        
    if(response.ok) {
      alert("Se pudieron mergear los documentos");

      var buttonDescarga = document.getElementById("descarga");
      buttonDescarga.disabled = false;

      nombreProyecto = (await response.json())["proyecto"];
      
    }
    else alert("Hubo un error. Por favor revisar los documentos");
  }

  const descargar = () => {
    // ipcRenderer.on("download complete", (event, file) => {
    //     console.log(file); // Full file path
    // });
    window.location.href = "/archivos/" + nombreProyecto + ".lsp";
  }

  const descargarBAT = () => {
    // ipcRenderer.on("download complete", (event, file) => {
    //     console.log(file); // Full file path
    // });
    window.location.href = "/archivos/reemplazoCaracteres.bat";
  }

  return (
    <>
      <div className="App">
        {/* <video autoPlay width="750" height="500" controls >
          <source src={"/video/gfp-astro-timelapse.mp4"} type="video/mp4"/>
        </video> */}

        <video autoPlay muted loop id="bg-video">
            <source src={"/video/gfp-astro-timelapse.mp4"} type="video/mp4"/>
        </video>
        <div className="page-container">
          <div className="container-fluid">
            <div className="row">
              <div className="col-xs-12">
                <div className="cd-slider-nav">
                  <nav className="navbar navbar-expand-lg" id="tm-nav">
                    <a className="navbar-brand" href="#"><img src="/img/hitachiEnergy.png" alt="Image" className="img-fluid intro-img-1" width="50%" length="50%"/></a>
                  </nav>
                </div>
              </div>          
            </div>        
          </div>      
          <div className="container-fluid tm-content-container">
            <ul className="cd-hero-slider mb-0 py-5">
              <li className="px-3" data-page-no="1">
                <div className="page-width-1 page-center">
                  <div className="d-flex position-relative tm-border-top tm-border-bottom intro-container">
                    <div className="intro-left tm-bg-dark" style={{textAlign: "left"}}>
                      <h2 className="mb-4">Subir Carpeta</h2>
                        {/* <input type="file" id="files_upload" directory mozDirectory webkitDirectory/><br/><br/><br/> */}
                        <input type="file" id="files_upload" directory="" webkitdirectory=""/><br/><br/><br/>
                        <label>Ingrese nombre de comando: </label><br/>
                        <input type="text" id="nombreComando" name="comando" placeholder="Nombre de comando"/>
                        <br/><br/>
                        <br/>
                    </div>
                    <div className="intro-right">
                      <img src="/img/pexels-marek-levak-2265482.jpg" alt="Image" className="img-fluid intro-img-1"/>
                      <img src="/img/pexels-anete-lusina-4792288.jpg" alt="Image" className="img-fluid intro-img-2"/>
                    </div>
                    <div className="circle intro-circle-1"></div>
                    <div className="circle intro-circle-2"></div>
                    <div className="circle intro-circle-3"></div>
                    <div className="circle intro-circle-4"></div>
                  </div>
                  <div className="text-center">
                    <div style={{textAlign: "center"}}>
                      <button onClick={() => postInformation()} className="btn btn-primary tm-intro-btn">Procesar archivo</button>
                      <button onClick={() => descargarBAT()} id="descargaBAT" className="btn btn-primary tm-intro-btn">Descargar .bat</button>
                      <button onClick={() => descargar()} id="descarga" disabled className="btn btn-primary tm-intro-btn">Descargar .lsp</button>
                    </div>
                  </div>            
                </div>            
              </li>
            </ul>
          </div>
          <div className="container-fluid">
            <footer className="row mx-auto tm-footer">
            </footer>
          </div>
        </div>

        {/* <div id="loader-wrapper">            
          <div id="loader"></div>
          <div className="loader-section section-left"></div>
          <div className="loader-section section-right"></div>
        </div>   */}
      </div>

      {/* <script src="js/jquery-3.5.1.min.js"></script>
      <script src="js/bootstrap.min.js"></script>
      <script src="js/slick.js"></script>
      <script src="js/templatemo-script.js"></script>
      <script src="https://cdnjs.cloudflare.com/ajax/libs/xlsx/0.17.5/xlsx.min.js"></script>  
      <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.3/jquery.min.js"></script> */}
    </>
  );
}

export default App;

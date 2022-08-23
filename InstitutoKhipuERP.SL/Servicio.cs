using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace InstitutoKhipuERP.SL
{
    [ServiceBehavior]
    public class Servicio:IServicioInstitutoKhipu
    {
        [OperationBehavior]
        public DataContract.TCarrera insertarTCarrera(DataContract.TCarrera request)
        {

            var response = new DataContract.TCarrera();
            var x = Traductores.TCarrera.HaciaTCarrera(request);
            x.Insertar();
            response = Traductores.TCarrera.HaciaTCarrera(x);
            return response;
        }

        [OperationBehavior]
        public DataContract.TCarrera actualizarTCarrera(DataContract.TCarrera request)
        {
            var response = new DataContract.TCarrera();
            var x = Traductores.TCarrera.HaciaTCarrera(request);
            x.Actualizar();
            response = Traductores.TCarrera.HaciaTCarrera(x);
            return response;
        }
        [OperationBehavior]
        public DataContract.TCarrera eliminarTCarrera(DataContract.TCarrera request)
        {
            var response = new DataContract.TCarrera();
            var x = Traductores.TCarrera.HaciaTCarrera(request);
            x.Eliminar();
            response = Traductores.TCarrera.HaciaTCarrera(x);
            return response;
        }
       [OperationBehavior]
        public DataContract.TCarrera SeleccionarTCarrera(string pCodCarrera)
        {
            var objResponse = new DataContract.TCarrera();
            var blAdm = new BL.Administrador();
            var traductor = new Traductores.TCarrera();
            objResponse = traductor.HaciaTCarrera1(blAdm.SeleccionarTCarrera(pCodCarrera));
            return objResponse;
        }
        [OperationBehavior]
        public DataContract.ListaTCarrera SeleccionarTCarreras()
        {
            var objResponse = new DataContract.ListaTCarrera();
            var blAdm = new BL.Administrador();
            var traductor = new Traductores.TCarrera();
            objResponse = traductor.HaciaTCarreras(blAdm.SeleccionarTCarreras());
            return objResponse;
        }





        [OperationBehavior]
        public DataContract.TCurso insertarTCurso(DataContract.TCurso request)
        {

            var response = new DataContract.TCurso();
            var x = Traductores.TCurso.HaciaTCurso(request);
            x.Insertar();
            response = Traductores.TCurso.HaciaTCurso(x);
            return response;
        }

        [OperationBehavior]
        public DataContract.TCurso actualizarTCurso(DataContract.TCurso request)
        {
            var response = new DataContract.TCurso();
            var x = Traductores.TCurso.HaciaTCurso(request);
            x.Actualizar();
            response = Traductores.TCurso.HaciaTCurso(x);
            return response;
        }
        [OperationBehavior]
        public DataContract.TCurso eliminarTCurso(DataContract.TCurso request)
        {
            var response = new DataContract.TCurso();
            var x = Traductores.TCurso.HaciaTCurso(request);
            x.Eliminar();
            response = Traductores.TCurso.HaciaTCurso(x);
            return response;
        }
        [OperationBehavior]
        public DataContract.TCurso SeleccionarTCurso(string pCodCurso)
        {
            var objResponse = new DataContract.TCurso();
            var blAdm = new BL.Administrador();
            var traductor = new Traductores.TCurso();
            objResponse = traductor.HaciaTCurso1(blAdm.SeleccionarTCurso(pCodCurso));
            return objResponse;
        }
        [OperationBehavior]
        public DataContract.ListaTCurso SeleccionarTCursos()
        {
            var objResponse = new DataContract.ListaTCurso();
            var blAdm = new BL.Administrador();
            var traductor = new Traductores.TCurso();
            objResponse = traductor.HaciaTCursos(blAdm.SeleccionarTCursos());
            return objResponse;
        }






        [OperationBehavior]
        public DataContract.TDocente insertarTDocente(DataContract.TDocente request)
        {

            var response = new DataContract.TDocente();
            var x = Traductores.TDocente.HaciaTDocente(request);
            x.Insertar();
            response = Traductores.TDocente.HaciaTDocente(x);
            return response;
        }

        [OperationBehavior]
        public DataContract.TDocente actualizarTDocente(DataContract.TDocente request)
        {
            var response = new DataContract.TDocente();
            var x = Traductores.TDocente.HaciaTDocente(request);
            x.Actualizar();
            response = Traductores.TDocente.HaciaTDocente(x);
            return response;
        }
        [OperationBehavior]
        public DataContract.TDocente eliminarTDocente(DataContract.TDocente request)
        {
            var response = new DataContract.TDocente();
            var x = Traductores.TDocente.HaciaTDocente(request);
            x.Eliminar();
            response = Traductores.TDocente.HaciaTDocente(x);
            return response;
        }
        [OperationBehavior]
        public DataContract.TDocente SeleccionarTDocente(string pCodDocente)
        {
            var objResponse = new DataContract.TDocente();
            var blAdm = new BL.Administrador();
            var traductor = new Traductores.TDocente();
            objResponse = traductor.HaciaTDocente1(blAdm.SeleccionarTDocente(pCodDocente));
            return objResponse;
        }
        [OperationBehavior]
        public DataContract.ListaTDocente SeleccionarTDocentes()
        {
            var objResponse = new DataContract.ListaTDocente();
            var blAdm = new BL.Administrador();
            var traductor = new Traductores.TDocente();
            objResponse = traductor.HaciaTDocentes(blAdm.SeleccionarTDocentes());
            return objResponse;
        }





        [OperationBehavior]
        public DataContract.TEstudiante insertarTEstudiante(DataContract.TEstudiante request)
        {

            var response = new DataContract.TEstudiante();
            var x = Traductores.TEstudiante.HaciaTEstudiante(request);
            x.Insertar();
            response = Traductores.TEstudiante.HaciaTEstudiante(x);
            return response;
        }

        [OperationBehavior]
        public DataContract.TEstudiante actualizarTEstudiante(DataContract.TEstudiante request)
        {
            var response = new DataContract.TEstudiante();
            var x = Traductores.TEstudiante.HaciaTEstudiante(request);
            x.Actualizar();
            response = Traductores.TEstudiante.HaciaTEstudiante(x);
            return response;
        }
        [OperationBehavior]
        public DataContract.TEstudiante eliminarTEstudiante(DataContract.TEstudiante request)
        {
            var response = new DataContract.TEstudiante();
            var x = Traductores.TEstudiante.HaciaTEstudiante(request);
            x.Eliminar();
            response = Traductores.TEstudiante.HaciaTEstudiante(x);
            return response;
        }
        [OperationBehavior]
        public DataContract.TEstudiante SeleccionarTEstudiante(string pCodEstudiante)
        {
            var objResponse = new DataContract.TEstudiante();
            var blAdm = new BL.Administrador();
            var traductor = new Traductores.TEstudiante();
            objResponse = traductor.HaciaTEstudiante1(blAdm.SeleccionarTEstudiante(pCodEstudiante));
            return objResponse;
        }
        [OperationBehavior]
        public DataContract.ListaTEstudiante SeleccionarTEstudiantes()
        {
            var objResponse = new DataContract.ListaTEstudiante();
            var blAdm = new BL.Administrador();
            var traductor = new Traductores.TEstudiante();
            objResponse = traductor.HaciaTEstudiantes(blAdm.SeleccionarTEstudiantes());
            return objResponse;
        }





        [OperationBehavior]
        public DataContract.TMatricula insertarTMatricula(DataContract.TMatricula request)
        {

            var response = new DataContract.TMatricula();
            var x = Traductores.TMatricula.HaciaTMatricula(request);
            x.Insertar();
            response = Traductores.TMatricula.HaciaTMatricula(x);
            return response;
        }

        [OperationBehavior]
        public DataContract.TMatricula actualizarTMatricula(DataContract.TMatricula request)
        {
            var response = new DataContract.TMatricula();
            var x = Traductores.TMatricula.HaciaTMatricula(request);
            x.Actualizar();
            response = Traductores.TMatricula.HaciaTMatricula(x);
            return response;
        }
        [OperationBehavior]
        public DataContract.TMatricula eliminarTMatricula(DataContract.TMatricula request)
        {
            var response = new DataContract.TMatricula();
            var x = Traductores.TMatricula.HaciaTMatricula(request);
            x.Eliminar();
            response = Traductores.TMatricula.HaciaTMatricula(x);
            return response;
        }
        [OperationBehavior]
        public DataContract.TMatricula SeleccionarTMatricula(string pCodMatricula)
        {
            var objResponse = new DataContract.TMatricula();
            var blAdm = new BL.Administrador();
            var traductor = new Traductores.TMatricula();
            objResponse = traductor.HaciaTMatricula1(blAdm.SeleccionarTMatricula(pCodMatricula));
            return objResponse;
        }
        [OperationBehavior]
        public DataContract.ListaTMatricula SeleccionarTMatriculas()
        {
            var objResponse = new DataContract.ListaTMatricula();
            var blAdm = new BL.Administrador();
            var traductor = new Traductores.TMatricula();
            objResponse = traductor.HaciaTMatriculas(blAdm.SeleccionarTMatriculas());
            return objResponse;
        }







        [OperationBehavior]
        public DataContract.TMatriculaSemetre insertarTMatriculaSemetre(DataContract.TMatriculaSemetre request)
        {

            var response = new DataContract.TMatriculaSemetre();
            var x = Traductores.TMatriculaSemetre.HaciaTMatriculaSemetre(request);
            x.Insertar();
            response = Traductores.TMatriculaSemetre.HaciaTMatriculaSemetre(x);
            return response;
        }

        [OperationBehavior]
        public DataContract.TMatriculaSemetre actualizarTMatriculaSemetre(DataContract.TMatriculaSemetre request)
        {
            var response = new DataContract.TMatriculaSemetre();
            var x = Traductores.TMatriculaSemetre.HaciaTMatriculaSemetre(request);
            x.Actualizar();
            response = Traductores.TMatriculaSemetre.HaciaTMatriculaSemetre(x);
            return response;
        }
        [OperationBehavior]
        public DataContract.TMatriculaSemetre eliminarTMatriculaSemetre(DataContract.TMatriculaSemetre request)
        {
            var response = new DataContract.TMatriculaSemetre();
            var x = Traductores.TMatriculaSemetre.HaciaTMatriculaSemetre(request);
            x.Eliminar();
            response = Traductores.TMatriculaSemetre.HaciaTMatriculaSemetre(x);
            return response;
        }
        [OperationBehavior]
        public DataContract.TMatriculaSemetre SeleccionarTMatriculaSemetre(string pCodMatriculaSemetre)
        {
            var objResponse = new DataContract.TMatriculaSemetre();
            var blAdm = new BL.Administrador();
            var traductor = new Traductores.TMatriculaSemetre();
            objResponse = traductor.HaciaTMatriculaSemetre1(blAdm.SeleccionarTMatriculaSemetre(pCodMatriculaSemetre));
            return objResponse;
        }
        [OperationBehavior]
        public DataContract.ListaTMatriculaSemetre SeleccionarTMatriculaSemetres(string pCodEstudiante)
        {
             var objResponse = new DataContract.ListaTMatriculaSemetre();
                var blAdm = new BL.Administrador();
                var traductor = new Traductores.TMatriculaSemetre();
                objResponse = traductor.HaciaTMatriculaSemetres(blAdm.SeleccionarTMatriculaSemetres(pCodEstudiante));
                return objResponse;
        }


     





        [OperationBehavior]
       public DataContract.TModuloCarrera insertarTModuloCarrera(DataContract.TModuloCarrera request)
        {

            var response = new DataContract.TModuloCarrera();
            var x = Traductores.TModuloCarrera.HaciaTModuloCarrera(request);
            x.Insertar();
            response = Traductores.TModuloCarrera.HaciaTModuloCarrera(x);
            return response;
        }

        [OperationBehavior]
        public DataContract.TModuloCarrera actualizarTModuloCarrera(DataContract.TModuloCarrera request)
        {
            var response = new DataContract.TModuloCarrera();
            var x = Traductores.TModuloCarrera.HaciaTModuloCarrera(request);
            x.Actualizar();
            response = Traductores.TModuloCarrera.HaciaTModuloCarrera(x);
            return response;
        }
        [OperationBehavior]
        public DataContract.TModuloCarrera eliminarTModuloCarrera(DataContract.TModuloCarrera request)
        {
            var response = new DataContract.TModuloCarrera();
            var x = Traductores.TModuloCarrera.HaciaTModuloCarrera(request);
            x.Eliminar();
            response = Traductores.TModuloCarrera.HaciaTModuloCarrera(x);
            return response;
        }
        [OperationBehavior]
        public DataContract.TModuloCarrera SeleccionarTModuloCarrera(string pCodModulo)
        {
            var objResponse = new DataContract.TModuloCarrera();
            var blAdm = new BL.Administrador();
            var traductor = new Traductores.TModuloCarrera();
            objResponse = traductor.HaciaTModuloCarrera1(blAdm.SeleccionarTModuloCarrera(pCodModulo));
            return objResponse;
        }
        [OperationBehavior]
        public DataContract.ListaTModuloCarrera SeleccionarTModuloCarreras()
        {
            var objResponse = new DataContract.ListaTModuloCarrera();
            var blAdm = new BL.Administrador();
            var traductor = new Traductores.TModuloCarrera();
            objResponse = traductor.HaciaTModuloCarreras(blAdm.SeleccionarTModuloCarreras());
            return objResponse;
        }






        [OperationBehavior]
        public DataContract.Usuario insertarUsuario(DataContract.Usuario request)
        {

            var response = new DataContract.Usuario();
            var x = Traductores.Usuario.HaciaUsuario(request);
            x.Insertar();
            response = Traductores.Usuario.HaciaUsuario(x);
            return response;
        }

        [OperationBehavior]
        public DataContract.Usuario actualizarUsuario(DataContract.Usuario request)
        {
            var response = new DataContract.Usuario();
            var x = Traductores.Usuario.HaciaUsuario(request);
            x.Actualizar();
            response = Traductores.Usuario.HaciaUsuario(x);
            return response;
        }
        [OperationBehavior]
        public DataContract.Usuario eliminarUsuario(DataContract.Usuario request)
        {
            var response = new DataContract.Usuario();
            var x = Traductores.Usuario.HaciaUsuario(request);
            x.Eliminar();
            response = Traductores.Usuario.HaciaUsuario(x);
            return response;
        }



        public  string ingresar(string pCodUsuario,string pcontraseña)
        {
            /*var response = new DataContract.Usuario();
            var x = Traductores.Usuario.HaciaUsuario(response);
            x.Insertar();
            response = Traductores.TModuloCarrera.HaciaTModuloCarrera(x);
            return response;


            var objResponse = new DataContract.ListaTModuloCarrera();
            var blAdm = new BL.Administrador();
            var traductor = new Traductores.TModuloCarrera();
            objResponse = traductor.HaciaTModuloCarreras(blAdm.SeleccionarTModuloCarreras());
            return objResponse;
            */
           
            var blAdm = new BL.Administrador();
            var traductor = new Traductores.Usuario();
           var objResponse = blAdm.ingresar(pCodUsuario,pcontraseña);
            return objResponse;
        }

    }
}

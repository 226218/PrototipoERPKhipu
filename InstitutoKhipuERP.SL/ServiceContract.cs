using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace InstitutoKhipuERP.SL
{
    [ServiceContract]
    public interface IServicioInstitutoKhipu
    {

        [OperationContract]
        DataContract.TCarrera insertarTCarrera(DataContract.TCarrera request);
        [OperationContract]
        DataContract.TCarrera actualizarTCarrera(DataContract.TCarrera request);
        [OperationContract]
        DataContract.TCarrera eliminarTCarrera(DataContract.TCarrera request);
        [OperationContract]
        DataContract.TCarrera SeleccionarTCarrera(string CodCarrera);
        [OperationContract]
        DataContract.ListaTCarrera SeleccionarTCarreras();




        [OperationContract]
        DataContract.TCurso insertarTCurso(DataContract.TCurso request);
        [OperationContract]
        DataContract.TCurso actualizarTCurso(DataContract.TCurso request);
        [OperationContract]
        DataContract.TCurso eliminarTCurso(DataContract.TCurso request);
        [OperationContract]
        DataContract.TCurso SeleccionarTCurso(string CodCurso);
        [OperationContract]
        DataContract.ListaTCurso SeleccionarTCursos();



        [OperationContract]
        DataContract.TDocente insertarTDocente(DataContract.TDocente request);
        [OperationContract]
        DataContract.TDocente actualizarTDocente(DataContract.TDocente request);
        [OperationContract]
        DataContract.TDocente eliminarTDocente(DataContract.TDocente request);
        [OperationContract]
        DataContract.TDocente SeleccionarTDocente(string CodDocente);
        [OperationContract]
        DataContract.ListaTDocente SeleccionarTDocentes();




        [OperationContract]
        DataContract.TEstudiante insertarTEstudiante(DataContract.TEstudiante request);
        [OperationContract]
        DataContract.TEstudiante actualizarTEstudiante(DataContract.TEstudiante request);
        [OperationContract]
        DataContract.TEstudiante eliminarTEstudiante(DataContract.TEstudiante request);
        [OperationContract]
        DataContract.TEstudiante SeleccionarTEstudiante(string CodEstudiante);
        [OperationContract]
        DataContract.ListaTEstudiante SeleccionarTEstudiantes();



        [OperationContract]
        DataContract.TMatricula insertarTMatricula(DataContract.TMatricula request);
        [OperationContract]
        DataContract.TMatricula actualizarTMatricula(DataContract.TMatricula request);
        [OperationContract]
        DataContract.TMatricula eliminarTMatricula(DataContract.TMatricula request);
        [OperationContract]
        DataContract.TMatricula SeleccionarTMatricula(string CodMatricula);
        [OperationContract]
        DataContract.ListaTMatricula SeleccionarTMatriculas();



        [OperationContract]
        DataContract.TMatriculaSemetre insertarTMatriculaSemetre(DataContract.TMatriculaSemetre request);
        [OperationContract]
        DataContract.TMatriculaSemetre actualizarTMatriculaSemetre(DataContract.TMatriculaSemetre request);
        [OperationContract]
        DataContract.TMatriculaSemetre eliminarTMatriculaSemetre(DataContract.TMatriculaSemetre request);
        [OperationContract]
        DataContract.TMatriculaSemetre SeleccionarTMatriculaSemetre(string CodMatriculaSemetre);
        [OperationContract]
        DataContract.ListaTMatriculaSemetre SeleccionarTMatriculaSemetres(string pCodUsuario);




        [OperationContract]
        DataContract.TModuloCarrera insertarTModuloCarrera(DataContract.TModuloCarrera request);
        [OperationContract]
        DataContract.TModuloCarrera actualizarTModuloCarrera(DataContract.TModuloCarrera request);
        [OperationContract]
        DataContract.TModuloCarrera eliminarTModuloCarrera(DataContract.TModuloCarrera request);
        [OperationContract]
        DataContract.TModuloCarrera SeleccionarTModuloCarrera(string CodModulo);
        [OperationContract]
        DataContract.ListaTModuloCarrera SeleccionarTModuloCarreras();


        [OperationContract]
        DataContract.Usuario insertarUsuario(DataContract.Usuario request);
        [OperationContract]
        DataContract.Usuario actualizarUsuario(DataContract.Usuario request);
        [OperationContract]
        DataContract.Usuario eliminarUsuario(DataContract.Usuario request);
        [OperationContract]
        string ingresar(string pCodUsuario,string pcontraseña);
       

        

    }
}

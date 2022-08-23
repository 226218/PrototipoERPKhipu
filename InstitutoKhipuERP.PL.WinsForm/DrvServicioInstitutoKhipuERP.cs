using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstitutoKhipuERP.PL.WinsForm.ProxyServicioInstitutoKhipuERP;
namespace InstitutoKhipuERP.PL.WinsForm
{
    class DrvServicioInstitutoKhipuERP
    {
        
        ServicioInstitutoKhipuClient client ;

        public DrvServicioInstitutoKhipuERP()
        {
          client  = new ServicioInstitutoKhipuClient();
        }

        public TCarrera insertarTCarrera(string pCodCarrera, string pNomCarrera, string pDescripcion)
        {
           TCarrera  NTCarrera= new TCarrera();
           NTCarrera.CodCarrera = pCodCarrera;
           NTCarrera.NomCarrera = pNomCarrera;
           NTCarrera.Descripcion = pDescripcion;
            return client.insertarTCarrera(NTCarrera);
        }
        public TCarrera actualizarTCarrera(string pCodCarrera, string pNomCarrera, string pDescripcion)
        {
            TCarrera NTCarrera = new TCarrera();
            NTCarrera.CodCarrera = pCodCarrera;
            NTCarrera.NomCarrera = pNomCarrera;
            NTCarrera.Descripcion = pDescripcion;
            return client.actualizarTCarrera(NTCarrera);
        }
        public TCarrera eliminarTCarrera(string pCodCarrera)
        {
            TCarrera NTCarrera = new TCarrera();
            NTCarrera.CodCarrera = pCodCarrera;

            return client.eliminarTCarrera(NTCarrera);
        }

        public TCarrera SeleccionaTCarrera(string pCodCarrera)
        {
            return client.SeleccionarTCarrera(pCodCarrera);
        }

        public ListaTCarrera SeleccionarTCarreras()
        {
            return client.SeleccionarTCarreras();
        }






        public TCurso insertarTCurso(string pCodCurso, string pNomCurso, int pHoras,
            int pCreditos, string pCodModulo,string pCodCarrera)
        {
            TCurso NTCurso = new TCurso();
            NTCurso.CodCurso = pCodCurso;
            NTCurso.NomCurso = pNomCurso;
            NTCurso.Horas = pHoras;
            NTCurso.Creditos = pCreditos;
            NTCurso.CodModulo = pCodModulo;
            NTCurso.CodCarrera = pCodCarrera;
            return client.insertarTCurso(NTCurso);
        }
        public TCurso actualizarTCurso(string pCodCurso, string pNomCurso, int pHoras,
            int pCreditos, string pCodModulo, string pCodCarrera)
        {
            TCurso NTCurso = new TCurso();
            NTCurso.CodCurso = pCodCurso;
            NTCurso.NomCurso = pNomCurso;
            NTCurso.Horas = pHoras;
            NTCurso.Creditos = pCreditos;
            NTCurso.CodModulo = pCodModulo;
            NTCurso.CodCarrera = pCodCarrera;
            return client.actualizarTCurso(NTCurso);
        }
        public TCurso eliminarTCurso(string pCodCurso)
        {
            TCurso NTCurso = new TCurso();
            NTCurso.CodCurso = pCodCurso;

            return client.eliminarTCurso(NTCurso);
        }

        public TCurso SeleccionaTCurso(string pCodCurso)
        {
            return client.SeleccionarTCurso(pCodCurso);
        }

        public ListaTCurso SeleccionarTCursos()
        {
            return client.SeleccionarTCursos();
        }









        public TDocente insertarTDocente(string pCodDocente, string pDni, string pApePaterno
            , string pApeMaterno,string pNombres)
        {
            TDocente NTDocente = new TDocente();
        NTDocente.CodDocente= pCodDocente; 
            NTDocente.Dni= pDni;
            NTDocente.ApePaterno= pApePaterno; 
            NTDocente.ApeMaterno= pApeMaterno; 
            NTDocente.Nombres= pNombres;
            return client.insertarTDocente(NTDocente);
        }
        public TDocente actualizarTDocente(string pCodDocente, string pDni, string pApePaterno
            , string pApeMaterno,string pNombres)
        {
            TDocente NTDocente = new TDocente();
            NTDocente.CodDocente = pCodDocente;
            NTDocente.Dni = pDni;
            NTDocente.ApePaterno = pApePaterno;
            NTDocente.ApeMaterno = pApeMaterno;
            NTDocente.Nombres = pNombres;
            return client.actualizarTDocente(NTDocente);
        }
        public TDocente eliminarTDocente(string pCodDocente)
        {
            TDocente NTDocente = new TDocente();
            NTDocente.CodDocente = pCodDocente;

            return client.eliminarTDocente(NTDocente);
        }

        public TDocente SeleccionaTDocente(string pCodDocente)
        {
            return client.SeleccionarTDocente(pCodDocente);
        }

        public ListaTDocente SeleccionarTDocentes()
        {
            return client.SeleccionarTDocentes();
        }









        public TEstudiante insertarTEstudiante(string pCodEstudiante, string pDni, string pApePaterno,
            string pApeMaterno, string pNombres, string pCodCarrera)
        {
            TEstudiante NTEstudiante = new TEstudiante();
             NTEstudiante.CodEstudiante= pCodEstudiante; 
            NTEstudiante.Dni =pDni; 
            NTEstudiante.ApePaterno= pApePaterno;
             NTEstudiante.ApeMaterno =pApeMaterno; 
            NTEstudiante.Nombres= pNombres; 
            NTEstudiante.CodCarrera=pCodCarrera;

            return client.insertarTEstudiante(NTEstudiante);
        }
        public TEstudiante actualizarTEstudiante(string pCodEstudiante, string pDni, string pApePaterno,
            string pApeMaterno, string pNombres, string pCodCarrera)
        {
            TEstudiante NTEstudiante = new TEstudiante();
            NTEstudiante.CodEstudiante = pCodEstudiante;
            NTEstudiante.Dni = pDni;
            NTEstudiante.ApePaterno = pApePaterno;
            NTEstudiante.ApeMaterno = pApeMaterno;
            NTEstudiante.Nombres = pNombres;
            NTEstudiante.CodCarrera = pCodCarrera;
            return client.actualizarTEstudiante(NTEstudiante);
        }
        public TEstudiante eliminarTEstudiante(string pCodEstudiante)
        {
            TEstudiante NTEstudiante = new TEstudiante();
            NTEstudiante.CodCarrera = pCodEstudiante;

            return client.eliminarTEstudiante(NTEstudiante);
        }

        public TEstudiante SeleccionaTEstudiante(string pCodEstudiante)
        {
            return client.SeleccionarTEstudiante(pCodEstudiante);
        }

        public ListaTEstudiante SeleccionarTEstudiantes()
        {
            return client.SeleccionarTEstudiantes();
        }










        public TMatricula insertarTMatricula(string pCodMatricula, string pCodEstudiante, 
            string pCodCarrera,string pCodModulo,string pSemestre, DateTime pFecha)
        {
            TMatricula NTMatricula = new TMatricula();
            NTMatricula.CodMatricula = pCodMatricula;
              NTMatricula.CodEstudiante= pCodEstudiante;
              NTMatricula.CodCarrera= pCodCarrera;
              NTMatricula.CodModulo= pCodModulo;
              NTMatricula.Semestre= pSemestre;
              NTMatricula.Fecha= pFecha;
            return client.insertarTMatricula(NTMatricula);
        }
        public TMatricula actualizarTMatricula(string pCodMatricula, string pCodEstudiante,
            string pCodCarrera, string pCodModulo, string pSemestre, DateTime pFecha)
        {
            TMatricula NTMatricula = new TMatricula();
            NTMatricula.CodMatricula = pCodMatricula;
            NTMatricula.CodEstudiante = pCodEstudiante;
            NTMatricula.CodCarrera = pCodCarrera;
            NTMatricula.CodModulo = pCodModulo;
            NTMatricula.Semestre = pSemestre;
            NTMatricula.Fecha = pFecha;
            return client.actualizarTMatricula(NTMatricula);
        }
        public TMatricula eliminarTMatricula(string pCodMatricula)
        {
            TMatricula NTMatricula = new TMatricula();
            NTMatricula.CodMatricula = pCodMatricula;

            return client.eliminarTMatricula(NTMatricula);
        }

        public TMatricula SeleccionaTMatricula(string pCodMatricula)
        {
            return client.SeleccionarTMatricula(pCodMatricula);
        }

        public ListaTMatricula SeleccionarTMatriculas()
        {
            return client.SeleccionarTMatriculas();
        }













        public TMatriculaSemetre insertarTMatriculaSemetre(string pCodMatriculaSemetre,string pCodMatricula,
            string pCodEstudiante,string pCodCurso,string pCodDocente,string pSemestre,string pNomCurso,int pNotaPromedio        
        )
        {
            TMatriculaSemetre NTMatriculaSemetre = new TMatriculaSemetre();
         NTMatriculaSemetre.CodMatriculaSemetre= pCodMatriculaSemetre;
            NTMatriculaSemetre.CodMatricula= pCodMatricula;
            NTMatriculaSemetre.CodEstudiante= pCodEstudiante;
            NTMatriculaSemetre.CodCurso= pCodCurso;
            NTMatriculaSemetre.CodDocente= pCodDocente;
            NTMatriculaSemetre.Semestre= pSemestre;
            NTMatriculaSemetre.NomCurso= pNomCurso;
            NTMatriculaSemetre.NotaPromedio= pNotaPromedio;
             return client.insertarTMatriculaSemetre(NTMatriculaSemetre);
        }
        public TMatriculaSemetre actualizarTMatriculaSemetre(string pCodMatriculaSemetre, string pCodMatricula,
            string pCodEstudiante, string pCodCurso, string pCodDocente, string pSemestre, string pNomCurso, int pNotaPromedio
        )
        {
            TMatriculaSemetre NTMatriculaSemetre = new TMatriculaSemetre();
            NTMatriculaSemetre.CodMatriculaSemetre = pCodMatriculaSemetre;
            NTMatriculaSemetre.CodMatricula = pCodMatricula;
            NTMatriculaSemetre.CodEstudiante = pCodEstudiante;
            NTMatriculaSemetre.CodCurso = pCodCurso;
            NTMatriculaSemetre.CodDocente = pCodDocente;
            NTMatriculaSemetre.Semestre = pSemestre;
            NTMatriculaSemetre.NomCurso = pNomCurso;
            NTMatriculaSemetre.NotaPromedio = pNotaPromedio;
            return client.actualizarTMatriculaSemetre(NTMatriculaSemetre);
        }
        public TMatriculaSemetre eliminarTMatriculaSemetre(string pCodMatriculaSemetre)
        {
            TMatriculaSemetre NTMatriculaSemetre = new TMatriculaSemetre();
            NTMatriculaSemetre.CodMatriculaSemetre = pCodMatriculaSemetre;

            return client.eliminarTMatriculaSemetre(NTMatriculaSemetre);
        }

        public TMatriculaSemetre SeleccionaTMatriculaSemetre(string pCodMatriculaSemetre)
        {
            return client.SeleccionarTMatriculaSemetre(pCodMatriculaSemetre);
        }

        public ListaTMatriculaSemetre SeleccionarTMatriculaSemetre(string pCodEstudiante)
        {
            return client.SeleccionarTMatriculaSemetres(pCodEstudiante);
        }












        public TModuloCarrera insertarTModuloCarrera(string pCodModulo,string pCodCarrera,
            int NroModulo ,string Semestre)
        {
            TModuloCarrera NTModuloCarrera = new TModuloCarrera();
            NTModuloCarrera.CodModulo= pCodModulo;
            NTModuloCarrera.CodCarrera= pCodCarrera;
            NTModuloCarrera.NroModulo= NroModulo;
            NTModuloCarrera.Semestre= Semestre;
            return client.insertarTModuloCarrera(NTModuloCarrera);
        }
        public TModuloCarrera actualizarTModuloCarrera(string pCodModulo,string pCodCarrera,
            int NroModulo ,string Semestre)
    {
            TModuloCarrera NTModuloCarrera = new TModuloCarrera();
            NTModuloCarrera.CodModulo = pCodModulo;
            NTModuloCarrera.CodCarrera = pCodCarrera;
            NTModuloCarrera.NroModulo = NroModulo;
            NTModuloCarrera.Semestre = Semestre;
            return client.actualizarTModuloCarrera(NTModuloCarrera);
        }
        public TModuloCarrera eliminarTModuloCarrera(string pCodModulo)
        {
            TModuloCarrera NTModuloCarrera = new TModuloCarrera();
            NTModuloCarrera.CodModulo = pCodModulo;

            return client.eliminarTModuloCarrera(NTModuloCarrera);
        }

        public TModuloCarrera SeleccionaTModuloCarrera(string pCodModulo)
        {
            return client.SeleccionarTModuloCarrera(pCodModulo);
        }

        public ListaTModuloCarrera SeleccionarTModuloCarreras()
        {
            return client.SeleccionarTModuloCarreras();
        }

        public string ingresar(string pCodUsuario, string pcontraseña)
        {
            return client.ingresar(pCodUsuario, pcontraseña);
        }








    }
}

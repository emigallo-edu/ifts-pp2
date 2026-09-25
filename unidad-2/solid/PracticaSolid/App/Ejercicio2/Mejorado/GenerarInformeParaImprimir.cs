namespace App.Ejercicio2.Mejorado
{
    public class GenerarInformeParaImprimir
    {
        private readonly GenerarImpresion _generarImpresion;

        public GenerarInformeParaImprimir()
        {
            this._generarImpresion = new GenerarImpresion();
        }

        public void Generar(Comision comision)
        {
            string texto = new InformeDeRiesgo().Generar(comision);
            this._generarImpresion.Generar(comision.Nombre, texto.ToString());
        }
    }
}
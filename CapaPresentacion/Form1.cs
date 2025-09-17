using CapaLogicaNegocio;
using CapaAccesoDatos;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        private Logica logica = new Logica();
        private ProcesoAprobacion puntaje = new ProcesoAprobacion();  
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbTipoDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cbTipoDocumento.Text == "Cedula")
            {
                if (int.Parse(tbPlazoSolicitado.Text) < 1 || int.Parse(tbPlazoSolicitado.Text) > 72)
                {
                    MessageBox.Show("El plazo de meses debe estar entre 1 mes y 72 meses.");
                }
                else
                {
                    int balanza = logica.calculoBalanza(int.Parse(tbIngresosTotales.Text), int.Parse(tbEgresosTotales.Text));

                    if (balanza == 0)
                    {
                        MessageBox.Show("El crédito será negado, debido a que su balanza es 0.");
                    }

                    {
                        double creditoBalanza = logica.calculoRelacionCreditoBalanza(int.Parse(tbMontoSolicitado.Text), int.Parse(tbPlazoSolicitado.Text), balanza);

                        if (creditoBalanza >= 0.95)
                        {
                            MessageBox.Show("Crédito negado, la relacion crédito balanza es demasiado alta.");
                        }
                        else
                        {
                            if (creditoBalanza >= 0.7 && creditoBalanza < 0.95)
                            {
                                puntaje.NroDoc = int.Parse(tbNumeroDocumento.Text);
                                int p = logica.consultarPuntaje(puntaje);

                                if (p >= 800)
                                {
                                    MessageBox.Show("Crédito aprobado.");
                                }
                                else
                                {
                                    MessageBox.Show("Crédito denegado, su puntaje no cumple las condiciones.");
                                }
                            }
                            else
                            {
                                if (creditoBalanza >= 0.4 && creditoBalanza < 0.7)
                                {
                                    puntaje.NroDoc = int.Parse(tbNumeroDocumento.Text);
                                    int p = logica.consultarPuntaje(puntaje);
                                    if (p >= 600)
                                    {
                                        MessageBox.Show("Crédito aprobado.");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Crédito denegado, su puntaje no cumple las condiciones requeridas.");
                                    }
                                }
                                else
                                {
                                    if (creditoBalanza < 0.4)
                                    {
                                        puntaje.NroDoc = int.Parse(tbNumeroDocumento.Text);
                                        int p = logica.consultarPuntaje(puntaje);
                                        if (p >= 400)
                                        {
                                            MessageBox.Show("Crédito aprobado.");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Crédito denegado, su puntaje no cumple las condiciones.");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }       
            }
            else
            {
                MessageBox.Show("No tiene la edad necesaria para obtener un crédito.");
            }

        }
    }
}

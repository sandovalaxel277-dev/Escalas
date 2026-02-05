using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Escalas
{
    public partial class Form1 : Form
    {
        Dictionary<string, string[]> escalas = new Dictionary<string, string[]>(StringComparer.OrdinalIgnoreCase)
        {
            {"Do", new string[]{"Do", "Re", "Mi", "Fa", "Sol", "La", "Si"}},
            {"Re", new string[]{"Re", "Mi", "Fa#", "Sol", "La", "Si", "Do#"}},
            {"Mi", new string[]{"Mi", "Fa#", "Sol#", "La", "Si", "Do#", "Re#"}},
            {"Fa", new string[]{"Fa", "Sol", "La", "Sib", "Do", "Re", "Mi"}},
            {"Sol", new string[]{"Sol", "La", "Si", "Do", "Re", "Mi", "Fa#"}},
            {"La", new string[]{"La", "Si", "Do#", "Re", "Mi", "Fa#", "Sol#"}},
            {"Si", new string[]{"Si", "Do#", "Re#", "Mi", "Fa#", "Sol#", "La#"}},
            // Agregadas: algunas escalas menores y claves con bemoles
            {"La menor", new string[]{"La", "Si", "Do", "Re", "Mi", "Fa", "Sol"}},
            {"Mi menor", new string[]{"Mi", "Fa#", "Sol", "La", "Si", "Do", "Re"}},
            {"Re menor", new string[]{"Re", "Mi", "Fa", "Sol", "La", "Sib", "Do"}},
            {"Sol menor", new string[]{"Sol", "La", "Sib", "Do", "Re", "Mib", "Fa"}},
            {"Do menor", new string[]{"Do", "Re", "Mib", "Fa", "Sol", "Lab", "Sib"}},
            {"Sib", new string[]{"Sib", "Do", "Re", "Mib", "Fa", "Sol", "La"}},
            {"Mib", new string[]{"Mib", "Fa", "Sol", "Lab", "Sib", "Do", "Re"}}
        };

        public Form1()
        {
            InitializeComponent();
            // Poblar comboboxes con opciones
            cmbBase.Items.AddRange(new object[] { "Do", "Re", "Mi", "Fa", "Sol", "La", "Si", "Sib", "Mib" });
            cmbBase.SelectedIndex = 0;

            cmbTipo.Items.AddRange(new object[] { "Mayor", "Menor" });
            cmbTipo.SelectedIndex = 0;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var baseNote = cmbBase.SelectedItem?.ToString() ?? string.Empty;
            var tipo = cmbTipo.SelectedItem?.ToString() ?? "Mayor";

            string key = tipo.Equals("Menor", StringComparison.OrdinalIgnoreCase)
                ? baseNote + " menor"
                : baseNote;

            if (escalas.TryGetValue(key, out var escalaNotas))
            {
                lblResultado.Text = string.Join(", ", escalaNotas);
            }
            else
            {
                lblResultado.Text = $"No disponible: {baseNote} ({tipo}).";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

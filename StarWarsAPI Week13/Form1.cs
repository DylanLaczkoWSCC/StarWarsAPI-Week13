using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWarsAPI_Week13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int planetId;
            if (int.TryParse(txtPlanetId.Text, out planetId))
            {
                string url = $"https://swapi.py4e.com/api/planets/{planetId}/";
                var planet = await JsonHelper.GetAsync<Planet>(url);
                if (planet != null)
                {
                    lblName.Text = $"Name: {planet.name}";
                    lblRotationPeriod.Text = $"Rotation Period: {planet.rotation_period}";
                    lblOrbitalPeriod.Text = $"Orbital Period: {planet.orbital_period}";
                    lbldiameter.Text = $"Diameter: {planet.diameter}";
                    lblclimate.Text = $"Climate: {planet.climate}";
                    lblgravity.Text = $"Gravity: {planet.gravity}";
                    lblterrain.Text = $"Terrain: {planet.terrain}";
                    lblsurfacewater.Text = $"Surface Water: {planet.surface_water}";
                    lblpopulation.Text = $"Population: {planet.population}";
                }
                else
                {
                    MessageBox.Show("Planet not found!");
                }
            }
            else
            {
                MessageBox.Show("Invalid planet ID!");
            }
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            int personID;
            if (int.TryParse(txbPersonID.Text, out personID))
            {
                string url = $"https://swapi.py4e.com/api/people/{personID}/";
                var person = await JsonHelper.GetAsync<Person>(url);
                if (person != null)
                {
                    lblPersonName.Text = $"Name: {person.name}";
                    lblHeight.Text = $"Height: {person.height}";
                    lblMass.Text = $"Mass: {person.mass}";
                    lblHairColor.Text = $"Hair Color: {person.hair_color}";
                    lblSkinColor.Text = $"Skin Color: {person.skin_color}";
                    lblEyeColor.Text = $"Eye Color: {person.eye_color}";
                    lblBirthYear.Text = $"Birth Year: {person.birth_year}";
                    lblGender.Text = $"Gender: {person.gender}";
                    lblHomeworld.Text = $"Homeworld: {person.homeworld}";
                }
                else
                {
                    MessageBox.Show("Person not found!");
                }
            }
            else
            {
                MessageBox.Show("Invalid person ID!");
            }
        }

        public async void button2_Click(object sender, EventArgs e)
        {
            string url = "https://swapi.py4e.com/api/species/";
            var speciesList = await JsonHelper.GetAsync<SpeciesResponse>(url);
            if (speciesList != null)
            {
                foreach (var species in speciesList.Results)
                {
                    listBoxSpecies.Items.Add($"Name: {species.name}");
                    listBoxSpecies.Items.Add($"Classification: {species.classification}");
                    listBoxSpecies.Items.Add($"Designation: {species.designation}");
                    listBoxSpecies.Items.Add($"Average Height: {species.average_height}");
                    listBoxSpecies.Items.Add($"Skin Colors: {species.skin_colors}");
                    listBoxSpecies.Items.Add($"Hair Colors: {species.hair_colors}");
                    listBoxSpecies.Items.Add($"Eye Colors: {species.eye_colors}");
                    listBoxSpecies.Items.Add($"Average Lifespan: {species.average_lifespan}");
                    listBoxSpecies.Items.Add($"Homeworld: {species.homeworld}");
                    listBoxSpecies.Items.Add($"Language: {species.language}");
                    listBoxSpecies.Items.Add($"\n");
                }
            }
        }
        // Assuming SpeciesResponse class represents the JSON response structure for a list of species
        public class SpeciesResponse
        {
            public List<Species> Results { get; set; }
            // Other properties as needed
        }
    }
    
    
}


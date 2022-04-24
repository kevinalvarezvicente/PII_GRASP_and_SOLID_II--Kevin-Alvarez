//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Text;
using Full_GRASP_And_SOLID.Library;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public void PrintRecipe()
        {
            ///Creo un StringBuilder que recolectara todos los datos a imprimir.
            StringBuilder recipe = new StringBuilder();

            recipe.Append($"Receta de {this.FinalProduct.Description}:\n");
            foreach (Step step in this.steps)
            {
                recipe.Append($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}\n");
            }
     
            IPrinter printer = new ConsolePrinter();
            printer.print(recipe);

        }
    }
}
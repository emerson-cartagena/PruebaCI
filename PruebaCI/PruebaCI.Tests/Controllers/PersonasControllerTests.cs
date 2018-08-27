using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebaCI.Controllers;
using PruebaCI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCI.Controllers.Tests
{
    [TestClass()]
    public class PersonasControllerTests
    {

        [TestMethod()]
        public void ValidarModeloPersona()
        {
            // Arrange            
            var persona = new Persona() { Nombre = String.Empty };

            // Act
            var context = new ValidationContext(persona, null, null);
            var results = new List<ValidationResult>();
            TypeDescriptor.AddProviderTransparent(new AssociatedMetadataTypeTypeDescriptionProvider(typeof(Persona), typeof(PersonaMetadata)), typeof(Persona));

            var isModelStateValid = Validator.TryValidateObject(persona, context, results, true);
            // Assert
            Assert.IsFalse(isModelStateValid);
        }       

    }
}
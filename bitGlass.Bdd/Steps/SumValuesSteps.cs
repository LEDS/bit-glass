using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace bitGlass.Bdd.Steps
{
    [Binding]
    public class SumValuesSteps
    {
        private double[] _inputs = new double[2];
        private double _result;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int first)
        {
            _inputs[0] = first;
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int second)
        {
            _inputs[1] = second;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _inputs.Sum();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            Assert.AreEqual(result, _result);
        }
    }
}

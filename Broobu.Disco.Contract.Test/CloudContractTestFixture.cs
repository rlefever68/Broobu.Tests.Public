// ***********************************************************************
// Assembly         : Broobu.Disco.Contract.Test
// Author           : Rafael Lefever
// Created          : 09-11-2014
//
// Last Modified By : Rafael Lefever
// Last Modified On : 09-05-2014
// ***********************************************************************
// <copyright file="CloudContractTestFixture.cs" company="Broobu">
//     Copyright (c) Broobu. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Wulka.Agent;
using Wulka.Domain;
using Wulka.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Broobu.Disco.Contract.Test
{
    /// <summary>
    /// Class CloudContractTestFixture.
    /// </summary>
    [TestClass]
    public class CloudContractTestFixture : ICloudContract
    {
        /// <summary>
        /// Try_s the save cloud contract.
        /// </summary>
        [TestMethod]
        public void Try_SaveCloudContract()
        {
            var c = new CloudContract() { 
                Id = "Test:CloudContract-you-cant-touch-me:ITest",
                Address = "http://www.someaddress.com/Still",
                Behaviour = "IBehave",
                Binding = "Net.Pope",
                ContractName = "SomeContract"
            };
            var res = SaveCloudContract(c);
            Console.WriteLine(res);
        }

        /// <summary>
        /// Gets the cloud contract.
        /// </summary>
        /// <param name="contractId">The contract identifier.</param>
        /// <returns>CloudContract.</returns>
        public CloudContract GetCloudContract(string contractId)
        {
            return DiscoPortal
                .CloudContracts
                .GetCloudContract(contractId);
        }

        /// <summary>
        /// Saves the cloud contracts.
        /// </summary>
        /// <param name="contracts">The contracts.</param>
        /// <returns>CloudContract[].</returns>
        public CloudContract[] SaveCloudContracts(CloudContract[] contracts)
        {
            return DiscoPortal
                .CloudContracts
                .SaveCloudContracts(contracts);

        }

        /// <summary>
        /// Saves the cloud contract.
        /// </summary>
        /// <param name="contract">The contract.</param>
        /// <returns>CloudContract.</returns>
        public CloudContract SaveCloudContract(CloudContract contract)
        {
            return DiscoPortal
                .CloudContracts
                .SaveCloudContract(contract);
        }
    }
}

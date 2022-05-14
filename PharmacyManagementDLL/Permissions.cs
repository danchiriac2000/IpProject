/**************************************************************************
 *                                                                        *
 *  File:        Permissions.cs                                           *
 *  Copyright:   (c) 2022, Gabriela Ursachi                               *
 *  E-mail:      gabriela.ursachi@student.tuiasi.ro                       *
 *  Description: This file contains permissions for different             *
 *                  user types.                                           *
 *                                                                        *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;



namespace PharmacyManagementDLL
{
    public class Permissions
    {
        private Dictionary<int,List<int>> _permissionsList;

        /// <summary>
        /// Permissions class constructor: initializes action rights depending on the position of each employee.
        /// </summary>
        public Permissions()
        {
            _permissionsList.Add(Constants.AssistantPharmacist, new List<int>() { Constants.SellRight,Constants.VerifyStockRight });
            _permissionsList.Add(Constants.Pharmacist, new List<int>() { Constants.SellRight, Constants.UpdateStockRight,
                    Constants.VerifyStockRight, Constants.AddProductRight });

        }


        /// <summary>
        /// Returns a list of action rights depending on the position of each employee.
        /// </summary>
        /// <param name="employeePosition">Occupation code within the pharmacy</param>
        /// <returns>Action rights list.</returns>
        public List<int> RightsList(int employeePosition)
        {
            if (_permissionsList.ContainsKey(employeePosition))
            {
                return _permissionsList[employeePosition];
            }
            return null;
        }


    }
}

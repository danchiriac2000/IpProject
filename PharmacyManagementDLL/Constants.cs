/**************************************************************************
 *                                                                        *
 *  File:        Constants.cs                                             *
 *  Copyright:   (c) 2022, Gabriela Ursachi                               *
 *  E-mail:      gabriela.ursachi@student.tuiasi.ro                       *
 *  Description: This file maintains codes for different properties       *
 *               of application.                                          *
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
    /// <summary>
    /// Constant codes for different access rights.
    /// </summary>
    public class Constants
    {
        public const int SellRight = 10;
        public const int VerifyStockRight = 11;
        public const int UpdateStockRight = 12;
        public const int AddProductRight = 13;

        
        //occupation codes within the pharmacy
        public const int Admin = -1;
        public const int Pharmacist = 0;
        public const int AssistantPharmacist = 1;
    }
}

﻿/*
 * microp11 2019
 * 
 * This file is part of IridiumLive.
 * 
 * IridiumLive is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * IridiumLive is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with IridiumLive.  If not, see <http://www.gnu.org/licenses/>.
 *
 *
 */

using System;

namespace IridiumLive.Data
{
    public class Sat
    {
        public string Id { get; set; }
        public int SatNo { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int OrbitalPlane { get; set; }
        public int PlaneSlot { get; set; }
        public string CatalogNumber { get; set; }
        public string Notes { get; set; }
        public string Author { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
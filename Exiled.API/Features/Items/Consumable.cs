// -----------------------------------------------------------------------
// <copyright file="Consumable.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.API.Features.Items
{
    using BaseConsumable = InventorySystem.Items.Usables.Consumable;

    /// <summary>
    /// A wrapper class for <see cref="BaseConsumable"/>.
    /// </summary>
    public class Consumable : Usable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Consumable"/> class.
        /// </summary>
        /// <param name="itemBase">The base <see cref="BaseConsumable"/> class.</param>
        public Consumable(BaseConsumable itemBase)
            : base(itemBase)
        {
            Base = itemBase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Consumable"/> class.
        /// </summary>
        /// <param name="type">The <see cref="ItemType"/> of the usable item.</param>
        internal Consumable(ItemType type)
            : this((BaseConsumable)Server.Host.Inventory.CreateItemInstance(type, false))
        {
        }

        /// <summary>
        /// Gets the <see cref="BaseConsumable"/> that this class is encapsulating.
        /// </summary>
        public new BaseConsumable Base { get; }
    }
}

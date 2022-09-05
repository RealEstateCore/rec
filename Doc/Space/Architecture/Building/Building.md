[Index](../../../index.md) > [Space](../../Space.md) > [Architecture](../Architecture.md) > [Building](#)
# Building

A confined building structure.


**Display name:** Building<br />
**DTMI:** dtmi:org:w3id:rec:Building;1

---

## Child interfaces
* [Hospital](Hospital.md)
* [School](School.md)
* [ShoppingMall](ShoppingMall.md)
* [Stadium](Stadium.md)
* [VirtualBuilding](VirtualBuilding.md)

---

## Components

### Inherited Components
* **[Architecture](../Architecture.md):** area, capacity

---

## Relationships

### Inherited Relationships
* **[Architecture](../Architecture.md):** address, adjacentElement, architectedBy, constructedBy, containsElement, documentation, hasPoint, intersectingElement, isFedBy, operatedBy, ownedBy
* **[Space](../../Space.md):** hasPart, isLocationOf, isPartOf

---

## Properties

### Inherited Properties
* **[Space](../../Space.md):** customTags, externalIds, geometry, name

---

## Target Of
### Inherited
* [Asset](../../../Asset/Asset.md).locatedIn
* [BuildingElement](../../../BuildingElement/BuildingElement.md).locatedIn
* [Campus](../../../Collection/Campus.md).includes
* [Premises](../../../Collection/Premises.md).includes
* [RealEstate](../../../Collection/RealEstate.md).includes
* [Space](../../Space.md).hasPart
* [Space](../../Space.md).isPartOf

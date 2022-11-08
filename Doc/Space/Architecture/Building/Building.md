[Index](../../../index.md) > [Space](../../Space.md) > [Architecture](../Architecture.md) > [Building](#)
# Building

A confined building structure.


**Display name:** Building<br />
**DTMI:** dtmi:org:w3id:rec:Building;1

---

## Child interfaces
* [Hospital](Hospital.md)
* [Stadium](Stadium.md)
* [School](School.md)
* [VirtualBuilding](VirtualBuilding.md)
* [ShoppingMall](ShoppingMall.md)

---

## Components

### Inherited Components
* **[Architecture](../Architecture.md):** area, capacity
* **[Space](../../Space.md):** georeference

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
* [BuildingElement](../../../BuildingElement/BuildingElement.md).locatedIn
* [Asset](../../../Asset/Asset.md).locatedIn
* [Space](../../Space.md).hasPart
* [Space](../../Space.md).isPartOf
* [RealEstate](../../../Collection/RealEstate.md).includes
* [Campus](../../../Collection/Campus.md).includes
* [Premises](../../../Collection/Premises.md).includes

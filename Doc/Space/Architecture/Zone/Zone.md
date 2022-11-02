[Index](../../../index.md) > [Space](../../Space.md) > [Architecture](../Architecture.md) > [Zone](#)
# Zone

A sub-zone within or outside of a building defined to support some technology and/or use, e.g., an HVAC zone, a parking space, a security zone, etc.


**Display name:** Zone<br />
**DTMI:** dtmi:org:w3id:rec:Zone;1

---

## Child interfaces
* [Workspace](Workspace.md)
* [AccessControlZone](AccessControlZone.md)
* [ParkingSpace](ParkingSpace.md)
* [HVACZone](HVACZone.md)
* [OccupancyZone](OccupancyZone.md)

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

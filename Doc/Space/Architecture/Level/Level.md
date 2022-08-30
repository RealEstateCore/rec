[Index](../../../Index.md) > [Space](../../Space.md) > [Architecture](../Architecture.md) > [Level](#)
# Level

The level of a building, a.k.a. storey, floor, etc.


**Display name:** Level<br />
**DTMI:** dtmi:org:w3id:rec:Level;1

---

## Child interfaces
* [BasementLevel](BasementLevel.md)
* [MezzanineLevel](MezzanineLevel.md)
* [RoofLevel](RoofLevel.md)

---

## Relationships

### Inherited Relationships
* **[Architecture](../Architecture.md):** address, adjacentElement, architectedBy, constructedBy, containsElement, documentation, hasPoint, intersectingElement, isFedBy, operatedBy, ownedBy
* **[Space](../../Space.md):** hasPart, isLocationOf, isPartOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|levelNumber|**en**: level number||integer|True|
### Inherited Properties
* **[Space](../../Space.md):** customTags, externalIds, geometry, name

---

## Target Of
### Inherited
* [Asset](../../../Asset/Asset.md).locatedIn
* [BuildingElement](../../../BuildingElement/BuildingElement.md).locatedIn
* [Campus](../../../Collection/Campus.md).includes
* [Premises](../../../Collection/Premises.md).includes
* [Space](../../Space.md).hasPart
* [Space](../../Space.md).isPartOf

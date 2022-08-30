[Index](../../../../Index.md) > [Space](../../../Space.md) > [Architecture](../../Architecture.md) > [Room](../Room.md) > [HealthcareRoom](#)
# HealthcareRoom

**Display name:** Healthcare room<br />
**DTMI:** dtmi:org:w3id:rec:HealthcareRoom;1

---

## Child interfaces
* [AdmittingRoom](AdmittingRoom.md)
* [Morgue](Morgue.md)
* [NeonatalNursingRoom](NeonatalNursingRoom.md)
* [OperatingRoom](OperatingRoom.md)
* [OutpatientServicesRoom](OutpatientServicesRoom.md)
* [PharmacyRoom](PharmacyRoom.md)
* [RadiologyRoom](RadiologyRoom.md)
* [TherapyRoom](TherapyRoom.md)

---

## Relationships

### Inherited Relationships
* **[Architecture](../../Architecture.md):** address, adjacentElement, architectedBy, constructedBy, containsElement, documentation, hasPoint, intersectingElement, isFedBy, operatedBy, ownedBy
* **[Space](../../../Space.md):** hasPart, isLocationOf, isPartOf

---

## Properties

### Inherited Properties
* **[Space](../../../Space.md):** customTags, externalIds, geometry, name

---

## Target Of
### Inherited
* [Asset](../../../../Asset/Asset.md).locatedIn
* [BuildingElement](../../../../BuildingElement/BuildingElement.md).locatedIn
* [Apartment](../../../../Collection/Apartment.md).includes
* [Campus](../../../../Collection/Campus.md).includes
* [Premises](../../../../Collection/Premises.md).includes
* [Space](../../../Space.md).hasPart
* [Space](../../../Space.md).isPartOf

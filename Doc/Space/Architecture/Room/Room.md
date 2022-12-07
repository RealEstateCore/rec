[Index](../../../index.md) > [Space](../../Space.md) > [Architecture](../Architecture.md) > [Room](#)
# Room

**Display name:** Room<br />
**DTMI:** dtmi:org:w3id:rec:Room;1

---

## Child interfaces
* [Atrium](Atrium.md)
* [Auditorium](Auditorium.md)
* [BackOffice](BackOffice/BackOffice.md)
* [Bathroom](Bathroom.md)
* [Bedroom](Bedroom.md)
* [Cinema](Cinema.md)
* [CleaningRoom](Cleaning-.md)
* [CloakRoom](Cloak-.md)
* [ConferenceRoom](Conference-.md)
* [ConversationRoom](Conversation-.md)
* [CopyingRoom](Copying-.md)
* [DressingRoom](Dressing-.md)
* [EducationalRoom](Educational-/EducationalRoom.md)
* [ElevatorRoom](Elevator-.md)
* [ElevatorShaft](ElevatorShaft.md)
* [Entrance](Entrance/Entrance.md)
* [ExerciseRoom](Exercise-.md)
* [ExhibitionRoom](Exhibition-.md)
* [FoodHandlingRoom](FoodHandling-/FoodHandlingRoom.md)
* [Garage](Garage/Garage.md)
* [Hallway](Hallway.md)
* [HealthcareRoom](Healthcare-/HealthcareRoom.md)
* [Laboratory](Laboratory/Laboratory.md)
* [LaundryRoom](Laundry-.md)
* [Library](Library.md)
* [LivingRoom](Living-.md)
* [LoadingReceivingRoom](LoadingReceiving-.md)
* [LockerRoom](Locker-.md)
* [MeditationRoom](Meditation-.md)
* [MothersRoom](Mothers-.md)
* [MultiPurposeRoom](MultiPurpose-.md)
* [Office](Office/Office.md)
* [PersonalHygiene](PersonalHygiene/PersonalHygiene.md)
* [Reception](Reception.md)
* [RecordingRoom](Recording-.md)
* [RecreationalRoom](Recreational-.md)
* [RestingRoom](Resting-.md)
* [RetailRoom](Retail-/RetailRoom.md)
* [SecurityRoom](Security-.md)
* [ServiceShaft](ServiceShaft.md)
* [Shelter](Shelter/Shelter.md)
* [StaffRoom](Staff-.md)
* [Stairwell](Stairwell.md)
* [Storage](Storage.md)
* [Theater](Theater.md)
* [TreatmentRoom](Treatment-/TreatmentRoom.md)
* [UtilitiesRoom](Utilities-/UtilitiesRoom.md)
* [WasteManagementRoom](WasteManagement-.md)
* [Workshop](Workshop.md)

---

## Components

### Inherited Components
* **[Architecture](../Architecture.md):** area, capacity

---

## Relationships

### Inherited Relationships
* **[Architecture](../Architecture.md):** address, adjacentElement, architectedBy, constructedBy, containsElement, documentation, hasPoint, intersectingElement, isFedBy, operatedBy, ownedBy
<<<<<<< HEAD
* **[Space](../../Space.md):** georeference, hasPart, isLocationOf, isPartOf
=======
* **[Space](../../Space.md):** geometry, hasPart, isLocationOf, isPartOf
>>>>>>> main

---

## Properties

### Inherited Properties
* **[Space](../../Space.md):** customTags, externalIds, name

---

## Target Of
### General
* [Point](../../../Point/Point.md).isPointOf
* [Agent](../../../Agent/Agent.md).owns
* [Space](../../Space.md).isLocationOf
* [Equipment](../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../Architecture.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
* [EquipmentCollection](../../../Collection/Equipment-.md).feeds
* [Lease](../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../Asset/Equipment/Meter/Meter.md).meters
### Direct
* [Apartment](../../../Collection/Apartment.md).includes
### Inherited
* [Asset](../../../Asset/Asset.md).locatedIn
* [BuildingElement](../../../BuildingElement/BuildingElement.md).locatedIn
* [Campus](../../../Collection/Campus.md).includes
* [Premises](../../../Collection/Premises.md).includes
* [RealEstate](../../../Collection/RealEstate.md).includes
* [Space](../../Space.md).hasPart
* [Space](../../Space.md).isPartOf

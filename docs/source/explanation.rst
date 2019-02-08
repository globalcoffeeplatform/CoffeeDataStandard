============================
 Global Coffee Data Standard
============================
This schema displays the initial basic Indicators for farm-level coffee sustainability, as originally determined by the GCP and the SPF Indicator Working Group. COSA--with feedback from the members of the Global Expert Committee--developed and synthesized practical metrics to operationalize the indicators so they can be functional across origins and comparable over time. The approach builds on global experience refined with tens of thousands of surveys and the expertise of the Committee members.

.. contents::
    :depth: 4

**********
1 Metadata
**********

1.1 globalCoffeeDatasetId
^^^^^^^^^^^^^^^^^^^^^^^^^
The unique identifier for this dataset.

.. todo:: Show sample JSON of ./global-unique-id.json

1.2 schemaVersion
^^^^^^^^^^^^^^^^^
The version number of the schema. When not provided the latest version of the schema will be used to validate the dataset.

********
2 farmer
********
The farmer characteristics

2.1 general
^^^^^^^^^^^

2.1.1 farmerId
--------------
Globally Unique ID of the farmer

Globally Unique ID of the recording of the farmer at a specific time and by a specific organization.

.. todo:: Show sample JSON of ./global-unique-id.json

2.1.2 name
----------
First and last name(s) of the farmer surveyed

First and last name(s) of the farmer surveyed. Initials should be avoided when possible. In places where farmers use only one name (a family name), that name should be entered as the Last Name and an appropriate prefix or 'Farmer' could be entered as the First Name.

2.1.2.1 firstName
*****************
First name(s) of the farmer surveyed

First name(s) of the farmer surveyed. In places where farmers use only one name (a family name), that name should be entered as the Last Name and an appropriate prefix or 'Farmer' could be entered as the First Name.

2.1.2.2 lastName
****************
Last name of the farmer surveyed

Last name of the farmer surveyed. Initials should be avoided when possible. In places where farmers use only one name (a family name), that name should be entered as the Last Name and an appropriate prefix or 'Farmer' could be entered as the First Name.

2.1.3 address
-------------
The location of the farm

Generally, data should include Country and then State/Department and Municipality/District, unless the address is collected for the sake of auditing. This should be the location of the farm itself (main plot), not the home of the farmer, if different.

.. todo:: Show sample JSON of ./address.json

2.1.4 dateOfBirth
-----------------
Date of birth.

Data point used to understand the relative presence of youth and calculate youth engagement: % of producers in the sustainability program or supply chain 35 years old and under

2.1.5 gender
------------
Gender

Data point used to understand the relative presence of women and to calculate women's engagement and the outcomes they experience as diverse from men: % of women in the sustainability program or supply chain

2.1.6 farmIds
-------------
Farm Ids

Which farms belong to this farmer. At least one is required.

2.1.7 thirdPartyIds
-------------------
Third-party identifier

When this dataset is reused by another organization who needs to use their own Global Unique Identifier, the original identifier can be saved here, to track history and origin.

2.2 social
^^^^^^^^^^

2.2.1 povertyLevel
------------------
Poverty level

Comparison of total household revenue to International (World Bank) Poverty Line (total divided by # adult individuals in hh)

2.2.1.1 totalHouseholdIncome
****************************
Total household income

Total household income in USD

2.2.1.2 householdMembers
************************
Household members

Number of adults in the household

2.2.2 childLabour
-----------------
Child labour


2.2.2.1 schoolAgeHouseholdMembers
*********************************
School-age household members

% of school-age household members, under age 18, who have completed appropriate grade level for their age

See :ref:`definitions_percentage`

2.2.2.2 hazardousProhibition
****************************
Prohibition of children in hazardous working conditions

Are young workers (those under age 18) working in hazardous conditions (applying chemical pesticides, using hazardous machinery, moving excessive weights/loads, etc.)

See :ref:`definitions_yesno`

2.2.3 hunger
------------
Hunger days

The number of days in the past year that any member of household cut food consumption due to lack of food.

******
3 farm
******
The farm characteristics

3.1 general
^^^^^^^^^^^

3.1.1 farmId
------------
Farm Id

Globally Unique ID of the recording of the farm at a specific time and by a specific organization.

.. todo:: Show sample JSON of ./global-unique-id.json

3.1.2 farmerId
--------------
Farmer Id

Globally Unique ID of the farmer of this farm

.. todo:: Show sample JSON of ./global-unique-id.json

3.1.3 location
--------------
GPS should be captured for each farm plot if possible. GPS readings should be taken outside of buildings and away from significant tree coverage to avoid interference in the signal. GPS should be captured in the middle of the plot, and/or near the entrance to any main building (if there is one). Where the main residence or other buildings are not located on the farm plot, GPS should be taken in the middle of the plot.

3.1.3.1 geoLocation
*******************
Front door geolocation


.. todo:: Show sample JSON of ./Point.json

3.1.3.2 positionTakenAt
***********************
The position was taken at ..


3.1.4 address
-------------
Farm address

This should be the location of the farm itself (main plot), not the home of the farmer, if different.

.. todo:: Show sample JSON of ./address.json

3.1.5 totalFarmSize
-------------------
Total farm size (ha)

Total Farm size refers to total property size, including land used to grow crops, pasture, wooded areas, land covered by buildings, and any other area included in the property. Best practice is to collect response in any given unit, and then perform conversion to a standard international unit (ha).

3.1.6 totalAreaCoffee
---------------------
Total Area planted in Coffee (ha)

Sum of coffee farm areas from producers in the sustainability program or supply chain (ha)

See :ref:`definitions_greaterthanzero`

3.1.7 thirdPartyIds
-------------------
Third-party identifier

When this dataset is reused by another organization that needs to use their own Global Unique Identifier, the original identifier can be saved here, to track history and origin.

3.2 social
^^^^^^^^^^

3.2.1 laborPractices
--------------------
Labor Practices

% of good labor practices adopted (of those listed). This indicator is applicable where farms rely on hired labor (not labor of household members).
# of good labor practices adopted / total number of practices

3.2.1.1 clearContracting
************************
Clear contracting

Percentage clear contracting with workers to avoid any form of forced labor (including slave labor or child labor), which includes: the terms of the work, hours, duration, wages, payment details, deductions or fees, etc.

See :ref:`definitions_percentage`

3.2.1.2 rightToOrganize
***********************
Right to organize

Percentage right to organize -- the ability for workers to join unions or committees and freely assemble

See :ref:`definitions_percentage`

3.2.1.3 prohibitingDiscrimination
*********************************
Prohibiting discrimination

Percentage prohibiting discrimination -- in terms of pay rates, hiring practices, housing for any group of workers (i.e., on the basis of immigration status, gender, ethnic or religious background, sexual orientation)

See :ref:`definitions_percentage`

3.2.1.4 hazardousWorkingCondition
*********************************
Hazardous working condition

Percentage hazardous working condition management--agrochemical protective gear; training on proper chemical handling, storage, and disposal; proper training and safeguarding for hazardous machinery, workplace sanitation, emergency preparedness, etc.

See :ref:`definitions_percentage`

3.2.2 wages
-----------
Wages

Daily average earnings for farm labor compared to (rural) minimum wage. Wage is listed and also expressed as a percentage of the rural minimum wage (where that exists), alternately to the national minimum wage.

3.2.2.1 wagesCoffee
*******************
The average daily wage rate paid for coffee production


3.2.2.2 wagesHarvesting
***********************
The average daily wage rate paid for harvesting


3.2.2.3 wagesProcessing
***********************
The average daily wage rate paid for processing


3.2.2.4 ruralMinimumWage
************************
Rural minimum wage


3.2.2.5 nationalMinimumWage
***************************
National minimum wage


3.3 economic
^^^^^^^^^^^^

3.3.1 coffeeProfit
------------------
Coffee Profit

Total revenue from coffee sales minus total costs for coffee production (Reported in USD/ha of coffee productive area.)

See :ref:`definitions_greaterthanzero`

3.3.2 productivity
------------------
Yield / Productivity

kgs of GBE (harvested)/ha of coffee productive area

3.3.2.1 coffeeProductiveArea
****************************
Coffee productive area

Coffee productive area (requires local land area unit conversion to hectares)

See :ref:`definitions_greaterthanzero`

3.3.2.2 amountHarvested
***********************
Amount harvested

Amount harvested (requires local unit conversion to kgs)--Amount sold can be a suitable proxy where harvested amounts are unknown (i.e., many smallholders will only know production volumes when their product is weighed at the mill)

See :ref:`definitions_greaterthanzero`

3.3.2.3 formOfCoffee
********************
Form of coffee

The form of coffee (will require conversion to GBE, Green Bean Equivalent)

3.3.3 productionCosts
---------------------
Cost of Production

Costs incurred to produce the coffee during the last production year (calculated per kg of GBE)

3.3.3.1 fertilizers
*******************
Fertilizers costs


.. todo:: Show sample JSON of ./productionCosts.json

3.3.3.2 pesticides
******************
Pesticides costs


.. todo:: Show sample JSON of ./productionCosts.json

3.3.3.3 hiredLabor
******************
Costs of hired labor


.. todo:: Show sample JSON of ./productionCosts.json

3.3.3.4 plantingMaterial
************************
Costs of planting material


.. todo:: Show sample JSON of ./productionCosts.json

3.3.3.5 renovation
******************
Costs of renovation


.. todo:: Show sample JSON of ./productionCosts.json

3.3.3.6 deductionsByBuyers
**************************
Deductions by buyers


.. todo:: Show sample JSON of ./productionCosts.json

3.3.3.7 rentOfLand
******************
Rent of land


.. todo:: Show sample JSON of ./productionCosts.json

3.3.3.8 energy
**************
Energy costs


.. todo:: Show sample JSON of ./productionCosts.json

3.3.3.9 irrigation
******************
Irrigation costs


.. todo:: Show sample JSON of ./productionCosts.json

3.3.3.10 capitalAssets
**********************
Capital assets


.. todo:: Show sample JSON of ./productionCosts.json

3.3.3.11 cultivationPractices
*****************************
Cultivation practices


.. todo:: Show sample JSON of ./productionCosts.json

3.3.3.12 traceabilityAndRecordKeeping
*************************************
Traceability and record keeping


.. todo:: Show sample JSON of ./productionCosts.json

3.3.3.13 standardsCertification
*******************************
Costs of standards or certifications


.. todo:: Show sample JSON of ./productionCosts.json

3.3.3.14 plantingReforestation
******************************
Planting and reforestation costs


.. todo:: Show sample JSON of ./productionCosts.json

3.3.3.15 training
*****************
Training costs


.. todo:: Show sample JSON of ./productionCosts.json

3.3.3.16 interest
*****************
Interest on credit


.. todo:: Show sample JSON of ./productionCosts.json

3.3.3.17 cropInsurance
**********************
Crop insurance


.. todo:: Show sample JSON of ./productionCosts.json

3.3.3.18 cooperativeFees
************************
Cooperative fees


.. todo:: Show sample JSON of ./productionCosts.json

3.3.3.19 unpaidFamilyLabor
**************************
Unpaid family labor


.. todo:: Show sample JSON of ./productionCosts.json

3.3.3.20 other
**************
Other costs


.. todo:: Show sample JSON of ./productionCosts.json

3.3.4 price
-----------
Average Price received per kg of coffee (GBE)

The simple approach involves asking for the total revenue received from coffee during the last production year as well as the amount sold (and the form). The average price per unit can then be calculated. For multiple sales, calculate the price average of sales

3.3.4.1 totalCoffeeRevenue
**************************
Total coffee revenue


3.3.4.2 kgSold
**************
kg of GBE sold


3.3.5 sustainablePurchases
--------------------------
Sustainable purchases

The volume of sustainable purchases by the buyer and as a proportion of the total, and change year to year.

3.3.5.1 volumeOfSustainablePurchases
************************************
Volume of sustainable purchases


3.3.5.2 proportionOfTotal
*************************
Proportion of total


See :ref:`definitions_percentage`

3.4 environmental
^^^^^^^^^^^^^^^^^

3.4.1 forestEcosystemProtection
-------------------------------
Forest and Ecosystem Protection


3.4.1.1 areaConvertedLand
*************************

3.4.1.1 absoluteArea
********************
Absolute area in ha


3.4.1.1 proportiesOfFarm
************************
Proportion of the farm


See :ref:`definitions_percentage`

3.4.1.2 ecosystemProtection
***************************
Forest and ecosystem protection

% of forest and ecosystem protection practices used on the farm

See :ref:`definitions_percentage`

3.4.2 fertilizerUse
-------------------
Fertilizer use

Whether a professional assessment or advice was used to determine fertilizer needs on the farm. It does not require in-depth fertilizer information: nutrient amounts, local commercial names, dosage amounts, application rates, etc.

See :ref:`definitions_yesno`

3.4.3 water
-----------
Water Conservation & Contamination Prevention


3.4.3.1 waterConservation
*************************

3.4.3.1 dripIrrigation
**********************
Drip irrigation


See :ref:`definitions_yesno`

3.4.3.1 waterCatchments
***********************
Water catchments


See :ref:`definitions_yesno`

3.4.3.1 waterEfficientProcessing
********************************
Water-efficient processing


See :ref:`definitions_yesno`

3.4.3.2 waterContamination
**************************

3.4.3.2 noPesticideCleaningNearWater
************************************
No pesticide cleaning near water

Pesticide equipment is cleaned away from natural water bodies

See :ref:`definitions_yesno`

3.4.3.2 preventUntreatedWater
*****************************
Prevent untreated water

Ensuring untreated water from processing does not enter natural water bodies

See :ref:`definitions_yesno`

3.4.3.2 noLivestockNearWater
****************************
No livestock near water

Grazing livestock away from natural water bodies

See :ref:`definitions_yesno`

3.4.3.2 noDomesticDischarge
***************************
No domestic discharge

Domestic discharge prevented from entering natural water bodies

See :ref:`definitions_yesno`

3.4.4 pestControl
-----------------
Pest control/ hazards


3.4.4.1 ipmPractices
********************

3.4.4.1 conductRegularVisualExaminations
****************************************
Conduct regular visual examinations

Conduct regular visual examinations of the coffee to detect pests and/or diseases

See :ref:`definitions_yesno`

3.4.4.1 useNaturalPesticides
****************************
Use natural pesticides

Use traps, repellants, and natural pesticides

See :ref:`definitions_yesno`

3.4.4.1 predatorPlaces
**********************
Predator places

Create or preserve places (including plant species) for beneficial predators of pests to live

See :ref:`definitions_yesno`

3.4.4.1 recordPestInfestation
*****************************
Record pest infestation

Maintain written record of pest infestation, treatments, and results

See :ref:`definitions_yesno`

3.4.4.1 pestRepelSpecies
************************
Pest repel species

Plant or preserve species that repel pests of the coffee

See :ref:`definitions_yesno`

3.4.4.1 applyAfterIdentifying
*****************************
Apply after identifying

Apply pesticide or kill pests only after identifying the pest and only at the best time in the pest’s life cycle to permanently reduce its population

See :ref:`definitions_yesno`

3.4.4.2 useOfBannedPesticides
*****************************
Use of banned or hazardous pesticides on the farm

Banned or hazardous pesticides* will be based on the WHO Ia and Ib lists. COSA suggests that over time it will be useful to understand the types and/ or individual banned pesticides being used so that research bodies can develop varietals or take other actions that help prevent the need for their use in the field. This approach does not address the proper disposal of pesticide containers.
Pesticides include insecticides, fungicides, rodenticides, nematicides, and herbicides.

3.4.5 soilConservation
----------------------
Soil Conservation

% of applicable soil conservation practices used on the farm (of those listed)

3.4.5.1 contourPlanting
***********************
Contour planting

Contour planting, terracing, or soil ridges around trees

See :ref:`definitions_yesno`

3.4.5.2 liveFences
******************
Live fences

Live fences, hedgerows or buffer zones

See :ref:`definitions_yesno`

3.4.5.3 recyclingOrganicMatter
******************************
Recycling organic matter

Recycling organic matter and crop waste

See :ref:`definitions_yesno`

3.4.5.4 interplanting
*********************
Interplanting

Interplanting, nitrogen-fixing plants, cover crops, or mulching

See :ref:`definitions_yesno`

3.4.5.5 checkDams
*****************
Check dams

Check dams, drainage channels or diversion ditches

See :ref:`definitions_yesno`

******
4 plot
******
The plot characteristics

4.1 general
^^^^^^^^^^^

4.1.1 plotId
------------
The unique ID of the plot

Globally Unique ID of the recording of the plot at a specific time and by a specific organization.

.. todo:: Show sample JSON of ./global-unique-id.json

4.1.2 farmId
------------
To which farm belongs this plot

Globally Unique ID farmId

.. todo:: Show sample JSON of ./global-unique-id.json

4.1.3 boundary
--------------
The boundary of the plot


4.1.4 area
----------
Area of the plot


4.1.5 thirdPartyIds
-------------------
Third-party identifier

When this dataset is reused by another organization who needs to use their own Global Unique Identifier, the original identifier can be saved here, to track history and origin.

4.2 economic
^^^^^^^^^^^^

4.2.1 yield
-----------
Yield

kgs of GBE (harvested)

4.2.2 productivity
------------------
Productivity

Total revenue from coffee sales minus total costs for coffee production (Reported in USD/ha of coffee productive area.)

See :ref:`definitions_positivenumber`

*************
5 Definitions
*************

.. _definitions_percentage:

5.1 percentage
^^^^^^^^^^^^^^
The percentage, 0-100

The percentage, from 0 to 100 with decimals allowed

.. _definitions_positivenumber:

5.2 positiveNumber
^^^^^^^^^^^^^^^^^^
A positive number > 0

A positive number starting at 0 with decimals allowed

.. _definitions_greaterthanzero:

5.3 greaterThanZero
^^^^^^^^^^^^^^^^^^^
The positive number, greater than 0

A positive number starting at greater than 0 with decimals allowed

.. _definitions_yesno:

5.4 yesNo
^^^^^^^^^
Yes-No enumeration


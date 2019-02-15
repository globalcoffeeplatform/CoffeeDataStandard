
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


.. literalinclude:: ../../schema/global-unique-id.json
   :language: json
   :linenos:
   :caption: Object description

.. literalinclude:: ../../example-data/testset.json
   :linenos:
   :lines: 2-6
   :caption: Sample data

1.2 schemaVersion
^^^^^^^^^^^^^^^^^
**Type**: *string*

**Allowed values**: '0.0.4'


The version number of the schema. When not provided the latest version of the schema will be used to validate the dataset.


********
2 farmer
********
**Type**: *object*


The farmer characteristics


2.1 general
^^^^^^^^^^^
**Type**: *object*


The general farmer characteristics


.. literalinclude:: ../../example-data/testset.json
   :linenos:
   :lines: 9-44
   :caption: Sample data

2.1.1 farmerId
--------------
Globally Unique ID of the farmer


Globally Unique ID of the recording of the farmer at a specific time and by a specific organization.


Each producer should have a unique ID. Optimally this can be a national ID, but in its absence a buyer ID, project ID or other unique number can serve. It is important to keep in mind that various entities may have access to reported data, so confidential information should not be included in the shared record (e.g. Social Security number).


.. literalinclude:: ../../schema/global-unique-id.json
   :language: json
   :linenos:
   :caption: Object description

2.1.2 name
----------
First and last name(s) of the farmer surveyed

**Type**: *object*


First and last name(s) of the farmer surveyed. Initials should be avoided when possible. In places where farmers use only one name (a family name), that name should be entered as the Last Name and an appropriate prefix or 'Farmer' could be entered as the First Name.


First and last name(s) of the farmer surveyed should be collected in separate fields/columns to ensure consistency (avoiding confusion between Carlos de la Huerta and De la Huerta, Carlos). Initials should be avoided when possible. In places where farmers use only one name (a family name), that name should be entered as the Last Name and an appropriate prefix or "Farmer" could be entered as the First Name.


2.1.2.1 firstName
*****************
First name(s) of the farmer surveyed

**Type**: *string*


First name(s) of the farmer surveyed. In places where farmers use only one name (a family name), that name should be entered as the Last Name and an appropriate prefix or 'Farmer' could be entered as the First Name.


2.1.2.2 lastName
****************
Last name of the farmer surveyed

**Type**: *string*


Last name of the farmer surveyed. Initials should be avoided when possible. In places where farmers use only one name (a family name), that name should be entered as the Last Name and an appropriate prefix or 'Farmer' could be entered as the First Name.


2.1.3 address
-------------
The location of the farm


Generally, data should include Country and then State/Department and Municipality/District, unless the address is collected for the sake of auditing. This should be the location of the farm itself (main plot), not the home of the farmer, if different.


.. literalinclude:: ../../schema/address.json
   :language: json
   :linenos:
   :caption: Object description

2.1.4 dateOfBirth
-----------------
Date of birth. [YYYY-MM-DD]

**Type**: *string*

**Pattern**: *^[12][0-9]{3}-[01][0-9]-[0-3][0-9]$*

.. raw:: html 

   <a href="https://regex101.com/r/SIq25G/1" target="_blank">Pattern validator</a>


Best practice is to use 'Year of Birth' as opposed to age. Age has to be updated annually, but year of birth is the same indefinitely, and can be used to calculate age at any point.


Data point used to understand the relative presence of youth and calculate youth engagement: % of producers in the sustainability program or supply chain 35 years old and under.


2.1.5 gender
------------
Gender

**Type**: *string*

**Allowed values**: 'M', 'F', 'O', 'NA'


Data point used to understand the relative presence of women and to calculate women's engagement and the outcomes they experience as diverse from men: % of women in the sustainability program or supply chain


2.1.6 farmIds
-------------
Farm Ids

**Type**: *array*


Which farms belong to this farmer. At least one is required.


2.1.7 thirdPartyIds
-------------------
Third-party identifier

**Type**: *array*


When this dataset is reused by another organization who needs to use their own Global Unique Identifier, the original identifier can be saved here, to track history and origin.


2.2 social
^^^^^^^^^^
**Type**: *object*


The social farmer characteristics


.. literalinclude:: ../../example-data/testset.json
   :linenos:
   :lines: 45-55
   :caption: Sample data

2.2.1 povertyLevel
------------------
Poverty level

**Type**: *object*


Comparison of total household revenue to International (World Bank) Poverty Line (total divided by # adult individuals in household).


The Monitoring approach is to ask producers the proportion of total household income coming from the sale of coffee (since the coffee revenue amount from the Net Income indicator (Profit) is already known, an estimate of the full household income amount can be derived with that proportion). This allows a good sense of the economic picture on the farm without adding substantial detail to the approach in terms of all household income streams (e.g., sales of other crops or services, income from other businesses, gifts and remittances, etc.) and any associated costs.

The World Bank International Poverty Line is $1.90 USD per day as of 2015. Comparison to national poverty lines may be useful for discussion related to one country or domestic policy but that can be calculated separately as needed.

An organization may choose to use the PPI score evaluation of the propensity of a farmer or community to be poor as another option that can be more relevant in some rural areas and can be calculated separately as needed. Organizations may also choose to participate on this topic in the Living Income Community of Practice.


2.2.1.1 totalHouseholdIncome
****************************
Total household income

**Type**: *number*

**Minimum**: *0*


Total household income in USD


2.2.1.2 householdMembers
************************
Household members

**Type**: *integer*

**Minimum**: *1*


Number of adults in the household


2.2.2 childLabour
-----------------
Child labour

**Type**: *object*


The issue of Child Labor is often addressed as a compliance audit question, but it is rarely answered because of the moral hazard (nobody wants to answer that they have child labor). Instead, "children in school at the appropriate grade level" serves to provide a valuable proxy that directly reflects an outcome of child labor and results in a better understanding of the plight of children in a community. Note that in many countries the compulsory school age may be lower than 18, and organizations are welcome to include other age limits in their own analysis of the data, but children in the appropriate grade for their age through 18 serves as an aspirational target. This data can be segmented by gender to get additional insights into the differences in education levels for both boys and girls in a community.


As an additional option, it may be desirable to ask whether young workers (those under age 18) are working in hazardous conditions (applying chemical pesticides, using hazardous machinery, moving excessive weights/loads, etc.)

These concepts are common to many sustainability standards and the approach is built on the ILO standards and the SDGs.


2.2.2.1 schoolAgeHouseholdMembers
*********************************
School-age household members

**Type**: See :ref:`definitions_percentage`

% of school-age household members, under age 18, who have completed appropriate grade level for their age


2.2.2.2 hazardousProhibition
****************************
Prohibition of children in hazardous working conditions

**Type**: See :ref:`definitions_yesno`

Are young workers (those under age 18) working in hazardous conditions (applying chemical pesticides, using hazardous machinery, moving excessive weights/loads, etc.)


2.2.3 hunger
------------
Hunger days

**Type**: *integer*

**Minimum**: *0*


Whether the household was food secure during the last production year (report 0 days of food insecurity--i.e., not skipping meals or significantly reducing food intake because food was not available).


The simple approach depends on asking the producer the number of days during the last production year that any member of household cut food consumption due to lack of food. It is good practice to ask this question in ranges of days to help with farmer recall: 0 days; 1-9 days, 10-19 days; 20-29 days; 30 or more days in the past year. Producers that answer '0 days' are considered to be food secure. Optimally, the approach would also include the months when food insecurity occurred in order to understand the times of year when producers experience more or less food security.

More comprehensive nutritional indicators can be expensive and require significant technical ability, time and resources to carry out effectively, so instead the focus is on days of food insecurity as a proxy. Note that while this survey question is often asked to the head of household, this indicator is best expressed when it includes multiple perspectives in the household. This indicator is an important human development issue and a core indicator for social justice.


******
3 farm
******
**Type**: *object*


The farm characteristics


3.1 general
^^^^^^^^^^^
**Type**: *object*


The general farm characteristics


.. literalinclude:: ../../example-data/testset.json
   :linenos:
   :lines: 58-82
   :caption: Sample data

3.1.1 farmId
------------
Farm Id


Globally Unique ID of the recording of the farm at a specific time and by a specific organization.


.. literalinclude:: ../../schema/global-unique-id.json
   :language: json
   :linenos:
   :caption: Object description

3.1.2 farmerId
--------------
Farmer Id


Globally Unique ID of the farmer of this farm


.. literalinclude:: ../../schema/global-unique-id.json
   :language: json
   :linenos:
   :caption: Object description

3.1.3 location
--------------
**Type**: *object*


GPS should be captured for each farm plot if possible. GPS readings should be taken outside of buildings and away from significant tree coverage to avoid interference in the signal. GPS should be captured in the middle of the plot, and/or near the entrance to any main building (if there is one). Where the main residence or other buildings are not located on the farm plot, GPS should be taken in the middle of the plot.


3.1.3.1 geoLocation
*******************
Front door geolocation


.. literalinclude:: ../../schema/Point.json
   :language: json
   :linenos:
   :caption: Object description

3.1.3.2 positionTakenAt
***********************
The position was taken at ..

**Type**: *string*

**Allowed values**: 'Location of the front door of the head office'


3.1.4 address
-------------
Farm address


This should be the location of the farm itself (main plot), not the home of the farmer, if different.


.. literalinclude:: ../../schema/address.json
   :language: json
   :linenos:
   :caption: Object description

3.1.5 totalFarmSize
-------------------
Total farm size (ha)

**Type**: See :ref:`definitions_greaterthanzero`

Total Farm size refers to total property size, including land used to grow crops, pasture, wooded areas, land covered by buildings, and any other area included in the property.


Best practice is to collect response in any given unit, and then perform conversion to a standard international unit (ha). Data validation should ensure that the total area planted in coffee should be less than the total farm size. It is ok to rely on farmer recall although more rigorous estimates will include GPS or polygonal mapping data. Consider that farms may contain multiple plots (plots are farm land areas that are not connected, or farm areas that are managed differently, or both). Make sure to add all relevant plots managed by members of a household together (that is, the farm area should coincide with the land used to account for the farm cost and revenue data being reported).


3.1.6 totalAreaCoffee
---------------------
Total Area planted in Coffee (ha)

**Type**: See :ref:`definitions_greaterthanzero`

Sum of coffee farm areas from producers in the sustainability program or supply chain (ha)


Area under coffee production can also be triangulated with other pieces of data collected (e.g., trees planted per unit land (density rate) and/or total number of trees planted).


3.1.7 thirdPartyIds
-------------------
Third-party identifier

**Type**: *array*


When this dataset is reused by another organization that needs to use their own Global Unique Identifier, the original identifier can be saved here, to track history and origin.


3.2 social
^^^^^^^^^^
**Type**: *object*


The social farm characteristics


.. literalinclude:: ../../example-data/testset.json
   :linenos:
   :lines: 83-96
   :caption: Sample data

3.2.1 laborPractices
--------------------
Labor Practices


% of good labor practices adopted (of those listed). This indicator is applicable where farms rely on hired labor (not labor of household members).


The percent refers to the number of good labor practices from the list that are adopted (meaning that each practice should have a binary response) and change over time is noted by the type and number of practices.

These concepts are common to many sustainability standards and the approach is built on the ILO standards and the SDGs. While there may be moral hazard in asking these questions outright, asking the questions themselves serves to educate the respondent about the norms and aspirations that are part of general good labor practices.


.. literalinclude:: ../../schema/labor-practices.json
   :language: json
   :linenos:
   :caption: Object description

3.2.2 wages
-----------
Wages

**Type**: *object*


Daily average earnings for farm labor compared to (rural) minimum wage. Wage is listed and also expressed as a percentage of the rural minimum wage (where that exists), alternately to the national minimum wage.


The approach involves asking for the average daily wage rate paid. If applicable, include wages for coffee production, harvesting, and processing and take an average across all three categories.

Wage is listed and also expressed as a percentage of the rural minimum wage (where that exists), alternately to the national minimum wage.

This approach gives a good sense of worker earnings coming from the most prominent types of labor without needing to detail individual jobs, rates, benefits, etc.

Organizations may wish to participate in working groups to define and measure living wage. There is still no widely used methodology, but the ability to understand whether a worker could survive on the wage earned would be useful for any industry. 


3.2.2.1 wagesCoffee
*******************
The average daily wage rate paid for coffee production

**Type**: *number*

**Minimum**: *0*


3.2.2.2 wagesHarvesting
***********************
The average daily wage rate paid for harvesting

**Type**: *number*

**Minimum**: *0*


3.2.2.3 wagesProcessing
***********************
The average daily wage rate paid for processing

**Type**: *number*

**Minimum**: *0*


3.2.2.4 ruralMinimumWage
************************
Rural minimum wage

**Type**: *number*

**Minimum**: *0*


3.2.2.5 nationalMinimumWage
***************************
National minimum wage

**Type**: *number*

**Minimum**: *0*


3.3 economic
^^^^^^^^^^^^
**Type**: *object*


The economic farm characteristics


.. literalinclude:: ../../example-data/testset.json
   :linenos:
   :lines: 97-138
   :caption: Sample data

3.3.1 coffeeProfit
------------------
Coffee Profit

**Type**: See :ref:`definitions_greaterthanzero`

Total revenue from coffee sales minus total costs for coffee production (Reported in USD/ha of coffee productive area.)


The simple approach (which avoids the additional time and resources necessary for detailed accounting while still providing good results) is to ask for the **total** revenue from sales of coffee as a whole, and subtract main costs. This indicator is reported on a per hectare basis to allow comparability across projects and regions.

This simplified approach does not cover asking the producer about revenue and prices for each transaction or amount sold, nor any premiums or deductions. It also factors in only the main costs in the coffee production system (see Cost of Production indicator below).


3.3.2 productivity
------------------
Yield / Productivity

**Type**: *object*


kgs of GBE (harvested)/ha of coffee productive area


3.3.2.1 coffeeProductiveArea
****************************
Coffee productive area

**Type**: See :ref:`definitions_greaterthanzero`

Coffee productive area (requires local land area unit conversion to hectares)


3.3.2.2 amountHarvested
***********************
Amount harvested

**Type**: See :ref:`definitions_greaterthanzero`

Amount harvested (requires local unit conversion to kgs)--Amount sold can be a suitable proxy where harvested amounts are unknown (i.e., many smallholders will only know production volumes when their product is weighed at the mill)


3.3.2.3 formOfCoffee
********************
Form of coffee

**Type**: *string*

**Allowed values**: 'Fresh cherry', 'Dry cherry', 'Dry parchment', 'Wet parchment', 'Green', 'Other'


The form of coffee (will require conversion to GBE, Green Bean Equivalent)


3.3.3 productionCosts
---------------------
Cost of Production


Costs incurred to produce the coffee during the last production year (calculated per kg of GBE)


The simple approach asks only about the main costs in the production system that typically account for the vast majority of total costs (and the total amount spent on each during the last production year). By focusing on the main costs in a system, this provides a good sense of the economic picture on the farm without adding substantial detail to the approach.

Main costs typically include (at a minimum):

* Fertilizers

* Pesticides

* Hired Labor

* Planting material/ Renovation costs

For those using the Full cost accounting approach the categories are comparable though fewer. The full approach would include: deductions by buyers, rent of land, energy, irrigation, capital assets, cultivation practices, traceability and record keeping, costs of standards or certifications, planting and reforestation costs, training costs, interest on credit, crop insurance, cooperative fees, or the value of unpaid family labor (although any important costs in a system should be captured).

Costs should be associated with the coffee production only (i.e., if labor is hired for multiple crops, only the portion used for coffee production should be included). One way to make sure that costs are correctly associated with the production of the coffee is to ask for the percent of inputs that were used for the coffee.

When calculating costs, include only expenditures coming from the household’s own revenue. If inputs are provided as technical assistance for free or at a subsidized cost on a **persistent**, **substantial**, and **systemic** basis it is recommended to account for the value of the input as a cost in the calculation (at an appropriately determined rate).


This indicator is a Sub-metric for Net Income (or Profit).


.. literalinclude:: ../../schema/production-costs.json
   :language: json
   :linenos:
   :caption: Object description

3.3.4 price
-----------
Average Price received per kg of coffee (GBE)

**Type**: *object*


The simple approach involves asking for the total revenue received from coffee during the last production year as well as the amount sold (and the form). The average price per unit can then be calculated. For multiple sales, calculate the price average of sales


The average price can then be compared to the global reference price (e.g., ICO).

This approach avoids the additional time and resources necessary for detailed accounting and asking about each sale (and the associated premiums, deductions or bonuses) while still providing good results.


3.3.4.1 totalCoffeeRevenue
**************************
Total coffee revenue

**Type**: *number*

**Minimum**: *0*


3.3.4.2 kgSold
**************
kg of GBE sold

**Type**: *number*

**Minimum**: *0*


3.3.5 sustainablePurchases
--------------------------
Sustainable purchases

**Type**: *object*


The volume of sustainable purchases by the buyer and as a proportion of the total, and change year to year.


Detailed methodology developed by the SPF Working Group (not a farmer level metric).


3.3.5.1 volumeOfSustainablePurchases
************************************
Volume of sustainable purchases

**Type**: *number*

**Minimum**: *0*


3.3.5.2 proportionOfTotal
*************************
Proportion of total

**Type**: See :ref:`definitions_percentage`

3.4 environmental
^^^^^^^^^^^^^^^^^
**Type**: *object*


The environmental farm characteristics


.. literalinclude:: ../../example-data/testset.json
   :linenos:
   :lines: 139-182
   :caption: Sample data

3.4.1 forestEcosystemProtection
-------------------------------
Forest and Ecosystem Protection

**Type**: *object*


The approach involves asking producers if they converted any natural land (e.g., forest, savanna) to land used for coffee production and how much [both in absolute terms (ha) and relative terms (proportion of the farm)] during the last 5 years.


In addition, overlaying gps coordinates of farms (See GPS Coordinate instructions above) with regional deforestation maps provides more interesting data at a landscape level to understand areas of risk. Note though that usually only a single gps point will exist for many smallholder farms, meaning that there often isn't sufficient information to track the contribution of individual farms to deforestation in most cases. However, even with single gps points, general farming areas prone to deforestation will still be visible.

**Forest and ecosystem protection practices** include: 

1. Reforestation with non-productive trees (i.e., those trees that will not be regularly pruned or removed)

2. Laying land aside (fallow) and/or blocking active use (including hunting).


3.4.1.1 areaConvertedLand
*************************
Area converted land

**Type**: *object*


Land area (in ha) and proportion of the farm that was converted from natural land (e.g.,, forest, savanna) to land used for coffee production in the last 5 years.


3.4.1.1 absoluteArea
********************
Absolute area in ha

**Type**: *number*

**Minimum**: *0*


3.4.1.1 proportiesOfFarm
************************
Proportion of the farm

**Type**: See :ref:`definitions_percentage`

3.4.1.2 ecosystemProtection
***************************
Forest and ecosystem protection

**Type**: See :ref:`definitions_percentage`

% of forest and ecosystem protection practices used on the farm


3.4.2 fertilizerUse
-------------------
Fertilizer use

**Type**: See :ref:`definitions_yesno`

Whether a professional assessment or advice was used to determine fertilizer needs on the farm. It does not require in-depth fertilizer information: nutrient amounts, local commercial names, dosage amounts, application rates, etc. 


The simple approach depends on asking the producer about fertilizer use best practices instead of all the individual fertilizer types and amounts they use. Asking if the producer based their fertilizer use on professional advice or assessments is easy to ask in a standardized way globally and can be a proxy for proper fertilization on the farm (there is ample evidence that the correlation between fertilizer use and yields is not as good as prescribed fertilization and yields).

Professional assessments include advice from an extension agent or other sustainability program implementer and NOT input sellers.

This approach does not require in-depth fertilizer information: nutrient amounts, local commercial names, dosage amounts, application rates, etc.


3.4.3 water
-----------
Water Conservation & Contamination Prevention

**Type**: *object*


Water conservation practices include (relevance of individual practices will need to be determined by region):


1. Drip irrigation

2. Water catchments

3. Water-efficient processing

For practices that conserve soil moisture balance and control runoff, please reference the "Soil Conservation" indicator below.

Water contamination prevention measures include the following:

1. Pesticide equipment is cleaned away from natural water bodies

2. Ensuring untreated water from processing does not enter natural water bodies

3. Grazing livestock away from natural water bodies

4. Domestic discharge prevented from entering natural water bodies

These concepts are common to many sustainability standards and the approach is built on FAO Good Agricultural Practices.

Asking about best practice adoption is a standardized way to address this indicator globally without the expensive and technical expertise required to measure water use amounts (and evaluating that in the local context) or taking water samples to evaluate contamination levels and the required protocols for that (taking samples at the appropriate locations and time, factoring in elements that may be beyond an individual producers control, etc.).


3.4.3.1 waterConservation
*************************
Water conservation practices

**Type**: *object*


% of applicable water conservation practices used on the farm (of those listed)


3.4.3.1 dripIrrigation
**********************
Drip irrigation

**Type**: See :ref:`definitions_yesno`

3.4.3.1 waterCatchments
***********************
Water catchments

**Type**: See :ref:`definitions_yesno`

3.4.3.1 waterEfficientProcessing
********************************
Water-efficient processing

**Type**: See :ref:`definitions_yesno`

3.4.3.2 waterContamination
**************************
Water contamination prevention practices

**Type**: *object*


% of water contamination prevention practices used on the farm (of those listed).


3.4.3.2 noPesticideCleaningNearWater
************************************
No pesticide cleaning near water

**Type**: See :ref:`definitions_yesno`

Pesticide equipment is cleaned away from natural water bodies


3.4.3.2 preventUntreatedWater
*****************************
Prevent untreated water

**Type**: See :ref:`definitions_yesno`

Ensuring untreated water from processing does not enter natural water bodies


3.4.3.2 noLivestockNearWater
****************************
No livestock near water

**Type**: See :ref:`definitions_yesno`

Grazing livestock away from natural water bodies


3.4.3.2 noDomesticDischarge
***************************
No domestic discharge

**Type**: See :ref:`definitions_yesno`

Domestic discharge prevented from entering natural water bodies


3.4.4 pestControl
-----------------
Pest control/ hazards

**Type**: *object*


**Standard IPM techniques include**:

* Conduct regular visual examinations of the coffee to detect pests and/or diseases

* Use traps, repellants, and natural pesticides

* Create or preserve places (including plant species) for beneficial predators of pests to live

* Maintain written record of pest infestation, treatments, and results

* Plant or preserve species that repel pests of the coffee

* Apply pesticide or kill pests only after identifying the pest and only at the best time in the pest’s life cycle to permanently reduce its population

Banned or hazardous pesticides will be based of the WHO Ia and Ib lists. COSA suggests that over time it will be useful to understand the types and/ or individual banned pesticides being used so that research bodies can develop varietals or take other actions that help prevent the need for their use in the field. This approach does not address proper disposal of pesticide containers.

Pesticides include insecticides, fungicides, rodenticides, nematicides and herbicides.

Focusing on IPM techniques is a globally standardized way to understand pest management best practices without the more costly and time-consuming process of detailing individual pesticides, active ingredients, amount used in local units, etc.


3.4.4.1 ipmPractices
********************
% of IPM practices employed on the farm

**Type**: *object*


Focusing on IPM techniques is a globally standardized way to understand pest management best practices without the more costly and time-consuming process of detailing individual pesticides, active ingredients, amount used in local units, etc.


3.4.4.1 conductRegularVisualExaminations
****************************************
Conduct regular visual examinations

**Type**: See :ref:`definitions_yesno`

Conduct regular visual examinations of the coffee to detect pests and/or diseases


3.4.4.1 useNaturalPesticides
****************************
Use natural pesticides

**Type**: See :ref:`definitions_yesno`

Use traps, repellants, and natural pesticides


3.4.4.1 predatorPlaces
**********************
Predator places

**Type**: See :ref:`definitions_yesno`

Create or preserve places (including plant species) for beneficial predators of pests to live


3.4.4.1 recordPestInfestation
*****************************
Record pest infestation

**Type**: See :ref:`definitions_yesno`

Maintain written record of pest infestation, treatments, and results


3.4.4.1 pestRepelSpecies
************************
Pest repel species

**Type**: See :ref:`definitions_yesno`

Plant or preserve species that repel pests of the coffee


3.4.4.1 applyAfterIdentifying
*****************************
Apply after identifying

**Type**: See :ref:`definitions_yesno`

Apply pesticide or kill pests only after identifying the pest and only at the best time in the pest’s life cycle to permanently reduce its population 


3.4.4.2 useOfBannedPesticides
*****************************
Use of banned or hazardous pesticides on the farm

**Type**: *array*


Banned or hazardous pesticides will be based on the WHO Ia and Ib lists. COSA suggests that over time it will be useful to understand the types and/ or individual banned pesticides being used so that research bodies can develop varietals or take other actions that help prevent the need for their use in the field. This approach does not address the proper disposal of pesticide containers.


Pesticides include insecticides, fungicides, rodenticides, nematicides, and herbicides.


3.4.5 soilConservation
----------------------
Soil Conservation

**Type**: *object*


% of applicable soil conservation practices used on the farm (of those listed)


**Soil conservation measures include**:

1. contour planting, terracing, or soil ridges around trees

2. live fences, hedgerows or buffer zones

3. recycling organic matter and crop waste

4. interplanting, nitrogen fixing plants, cover crops, or mulching

5. check dams, drainage channels or diversion ditches

These concepts are common to many sustainability standards and the approach is built on FAO Good Agricultural Practices.

Asking about best practice adoption is a standardized way to address this indicator globally without the expensive and technical expertise required to measure the actual amount of soil conserved or to do individual soil testing on farms.


3.4.5.1 contourPlanting
***********************
Contour planting

**Type**: See :ref:`definitions_yesno`

Contour planting, terracing, or soil ridges around trees


3.4.5.2 liveFences
******************
Live fences

**Type**: See :ref:`definitions_yesno`

Live fences, hedgerows or buffer zones


3.4.5.3 recyclingOrganicMatter
******************************
Recycling organic matter

**Type**: See :ref:`definitions_yesno`

Recycling organic matter and crop waste


3.4.5.4 interplanting
*********************
Interplanting

**Type**: See :ref:`definitions_yesno`

Interplanting, nitrogen-fixing plants, cover crops, or mulching


3.4.5.5 checkDams
*****************
Check dams

**Type**: See :ref:`definitions_yesno`

Check dams, drainage channels or diversion ditches


******
4 plot
******
**Type**: *object*


The plot characteristics


4.1 general
^^^^^^^^^^^
**Type**: *object*


The general plot characteristics


.. literalinclude:: ../../example-data/testset.json
   :linenos:
   :lines: 184-213
   :caption: Sample data

4.1.1 plotId
------------
The unique ID of the plot


Globally Unique ID of the recording of the plot at a specific time and by a specific organization.


.. literalinclude:: ../../schema/global-unique-id.json
   :language: json
   :linenos:
   :caption: Object description

4.1.2 farmId
------------
To which farm belongs this plot


Globally Unique ID farmId


.. literalinclude:: ../../schema/global-unique-id.json
   :language: json
   :linenos:
   :caption: Object description

4.1.3 boundary
--------------
The boundary of the plot


4.1.4 area
----------
Area of the plot

**Type**: *number*

**Minimum**: *0*


4.1.5 thirdPartyIds
-------------------
Third-party identifier

**Type**: *array*


When this dataset is reused by another organization who needs to use their own Global Unique Identifier, the original identifier can be saved here, to track history and origin.


4.2 economic
^^^^^^^^^^^^
**Type**: *object*


The economic plot characteristics


.. literalinclude:: ../../example-data/testset.json
   :linenos:
   :lines: 214-217
   :caption: Sample data

4.2.1 yield
-----------
Yield

**Type**: *number*

**Minimum**: *0*


kgs of GBE (harvested)


4.2.2 productivity
------------------
Productivity

**Type**: See :ref:`definitions_positivenumber`

Total revenue from coffee sales minus total costs for coffee production (Reported in USD/ha of coffee productive area.)


*************
5 Definitions
*************

.. _definitions_percentage:

5.1 percentage
^^^^^^^^^^^^^^
The percentage, 0-100

**Type**: *number*

**Minimum**: *0*

**Maximum**: *100*


The percentage, from 0 to 100 with decimals allowed


.. _definitions_positivenumber:

5.2 positiveNumber
^^^^^^^^^^^^^^^^^^
A positive number > 0

**Type**: *number*

**Minimum**: *0*


A positive number starting at 0 with decimals allowed


.. _definitions_greaterthanzero:

5.3 greaterThanZero
^^^^^^^^^^^^^^^^^^^
The positive number, greater than 0

**Type**: *number*

**Exclusive minimum**: *0*


A positive number starting at greater than 0 with decimals allowed


.. _definitions_yesno:

5.4 yesNo
^^^^^^^^^
Yes-No enumeration

**Type**: *string*

**Allowed values**: 'Yes', 'No'



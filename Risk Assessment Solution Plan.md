### RA-1 — Policy and Procedures (Control)

This requirement is about making sure the organisation has a clear, written plan for how it will identify and assess risks, who is responsible, and how the plan will be kept up to date. Without this, the organisation could miss important threats, make inconsistent decisions across different teams, or fail to respond when laws, rules, or real incidents change—leaving it exposed to avoidable harm and compliance problems.

The organisation must create and document a risk assessment policy and practical procedures for carrying it out. These documents must cover the purpose of the risk assessment, what it applies to, the roles and responsibilities, management support, how different parts of the organisation will work together, and how legal and regulatory expectations are met.

The Chief Information Security Officer must oversee creating, documenting, and sharing these documents. The policy must be reviewed at least every year, and also after any risk assessment or audit findings, confirmed security incidents or breaches, or significant changes to relevant requirements. The procedures must follow the same approach, with updates after material findings or confirmed incidents.

##### CISO-owned risk assessment policy and role-based procedures

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain an organisation-approved **risk assessment policy** and **risk assessment procedures** that set out how risk assessments are carried out across the organisation (and, where needed, at mission/business process and system levels).

###### WHY (control requirement)
RA-1 requires that the risk assessment policy and procedures are put in place and kept up to date, so the organisation can assess risks in a consistent way, coordinate security and privacy work, and update the policy/procedures when specified events happen. The guidance also says it is not enough to simply repeat the control requirements; the policy/procedures must be meaningful and practical for the organisation to use.

###### HOW (specific steps/approach)
1. **Draft the risk assessment policy** as an organisation-level document (or a small set of documents if the organisation’s structure requires it), owned by the **Chief Information Security Officer (CISO)**. It should cover: purpose, scope (organisation/mission/business process/system levels), roles and responsibilities, leadership commitment, coordination between security and privacy programmes, and alignment to relevant laws/regulations/standards/guidance.
2. **Set distribution lists** for the policy and procedures so the right people receive them.  
   - Policy: CISO, security and privacy programme leads, system owners, mission/business process owners  
   - Procedures: risk management team, security engineers, privacy officers, information system security officers
3. **Write role-based procedures** that explain how the policy is applied in practice, including how risk assessments are started, carried out, recorded, reviewed/approved, and escalated. Make sure the procedures describe implementation, not just repeat control wording.
4. **Define update triggers and review timing**:  
   - Review/update the policy **annually**, and after events such as assessment/audit findings, security incidents/breaches, and changes to relevant laws/executive directives/regulations/policies/standards/guidance.  
   - Review/update the procedures **annually**, and after material assessment/audit findings, confirmed incidents/breaches, and significant changes to relevant requirements.
5. **Use document control and keep evidence**: publish the policy/procedures in the organisation’s document management system with version numbers, approval records, and distribution/acknowledgement logs. Ensure system security and privacy plans point to the relevant procedures where system-level tailoring is needed.

###### WHO (role responsible)
- **CISO**: accountable for managing the risk assessment policy and procedures (ownership, approval, and governance).
- **Security programme lead + Privacy programme lead**: jointly develop and validate the policy/procedures to ensure security and privacy work together effectively.
- **Risk management team / security engineers / privacy officers / information system security officers (ISSOs)**: implement and maintain the procedures in day-to-day working practices.

###### Acceptance criteria
- A current, approved **risk assessment policy** exists, is owned by the **CISO**, and includes purpose, scope, roles/responsibilities, security/privacy coordination, and compliance alignment.
- A current, approved set of **risk assessment procedures** exists, is role-based, and describes how to carry out the work and what outputs/records are required (not just repeating control text).
- Distribution can be shown: named roles have received the policy/procedures, with documented distribution/acknowledgement logs.
- Review/update timing is followed: the policy is reviewed at least **annually** and after defined events; the procedures are reviewed at least **annually** and after defined material events.
- Evidence is kept for document control: approvals, version history, and the reasons for updates triggered by events.

###### Actions Required for Compliance

- [ ] Draft and obtain formal approval for an organisation-wide risk assessment policy, which is owned by the Chief Information Security Officer (CISO).
- [ ] Create and publish distribution lists for the policy and for the procedures, and share them with the specified roles.
- [ ] Create role-based risk assessment procedures that set out the steps to follow and the required outputs and records.
- [ ] Set and document a review and update schedule: review the policy and procedures every year, and update them after each of the defined events.
- [ ] Set up document control with version tracking, recorded approvals, and evidence that documents were shared and acknowledged.
- [ ] Publish the policy and procedures, and reference them in the system security and privacy plans where system-specific tailoring is needed.


---

### RA-2 — Security Categorization (Control)

This requirement is about making sure your organisation clearly decides how sensitive each system and the information it handles really is, based on what harm could happen if that information were exposed, changed, or became unavailable. Without this, you might treat highly sensitive information the same as lower-risk material, which could leave the business, its assets, and its people exposed to avoidable damage, legal problems, or operational disruption.

To meet this expectation, the organisation must assign a security category to the system and to all relevant information it processes, stores, and transmits, and record both the decision and the plain-language reasons for it in the system’s security plan. The organisation must also ensure that the authorised decision-maker, or someone officially appointed to act for them, reviews the categorisation and formally approves it based on the documented results, and keeps the categorisation accurate as systems and the way information is handled change.

##### RA-2 security categorisation workflow with documented approval

- Category: Manual
- Priority: Critical

###### WHAT
Set up a security categorisation process across the whole organisation. This process must assign a security category to the application system and to each type of information the system handles (including information it processes, stores, or sends). The categories must be based on the potential harm to the organisation’s operations and assets, and to individuals (including privacy impacts). Record the categorisation results and a plain-language explanation (including where the evidence came from) in the application’s security plan, and get formal approval from the authorised official (or their nominated representative).

###### WHY (control requirement)
RA-2 requires the organisation to carry out security categorisation as an organisation-wide activity. This should involve senior information security and privacy leadership, system owners, and information owners or information stewards. The categorisation must be based on potential harm to confidentiality, integrity, and availability. The results and reasons must be documented in the application’s security plan, and the authorised official (or nominated representative) must review and formally approve the categorisation.

###### HOW (specific steps/approach)
1. **Create and maintain a standard mapping** from “confidentiality, integrity, and availability” impact levels to security categories. All systems must use this, including privacy impact considerations where relevant, so the application’s categorisation is consistent and can be repeated.
2. **Categorise the application system and each information type/data set** (for example: customer records, employee data, financial and operational data, intellectual property, and regulated data). For each one, identify the potential adverse impacts to **confidentiality, integrity, and availability** (including disruption to business operations and impacts to individuals).
3. **Update the application’s security plan** to include:
   - the assigned security category for the system and for each relevant information type/data set;
   - the **written rationale** in plain language, and the **evidence sources** (for example: outputs from privacy impact assessments, business impact assessments, legal and regulatory requirements, and contractual obligations);
   - references to where the supporting evidence is stored.
4. **Send the categorisation package to the authorised official (or nominated representative)** for explicit review and formal approval (not just acknowledgement). Record the approval decision and date in an auditable record.
5. **Re-categorise when material changes occur** (for example: new types of data, new external sharing, major changes to the system design, or changes to regulatory or privacy scope). Use the organisation’s change and release governance so categories stay accurate and relevant.

###### WHO (role responsible)
- **System Owner / Application Owner**: responsible for completing the categorisation inputs for the application system.
- **Information Owner / Information Steward(s)**: responsible for categorising each information type/data set.
- **Senior Agency Information Security Officer / Chief Information Officer (as applicable in your organisation)**: ensures the organisation-wide categorisation approach is followed.
- **Senior Privacy Official (as applicable)**: provides privacy impact evidence and inputs.
- **Authorised Official (or nominated representative)**: reviews and formally approves the categorisation decision.
- **Governance, Risk and Compliance (GRC) / Compliance Lead**: maintains the workflow, templates, evidence linking, and audit trail.

###### Acceptance criteria
- The application has an approved security categorisation documented in the security plan, covering the **system** and **all relevant information types/data sets** it processes, stores, or transmits.
- The categorisation rationale is documented in plain language and includes evidence sources (for example: privacy impact assessment / business impact assessment / legal and regulatory requirements), with pointers to where evidence is stored.
- The categorisation decision has an auditable **formal approval** by the authorised official (or nominated representative), including the approval date and the identity of the approver.
- A defined change trigger is in place and operating, so that material changes to data types, data flows, sharing, or system design trigger a re-categorisation review.

###### Actions Required for Compliance

- [ ] Define and publish a standard mapping from confidentiality, integrity, and availability (CIA) impact levels to security categories, and use it for all application systems.
- [ ] Complete the security classification for the application system and for every relevant type of information and data set, using a confidentiality, integrity and availability (CIA) impact assessment (including privacy impacts where applicable).
- [ ] In the application’s system security plan, record the categorisation results and provide a plain-language explanation for why they were chosen, including the evidence sources used.
- [ ] Get formal approval for the categorisation decision from the authorised official (or their nominated representative) and keep a record of the approval evidence for audit purposes.
- [ ] Link the evidence used for link categorisation to the system security plan, including where any privacy impact, business impact, and legal evidence is stored.
- [ ] Set up change triggers in governance so that any significant changes to data types, data movement, data sharing, or system architecture automatically start a review to re-categorise the data.


---

#### RA-2.1 — Impact-level Prioritization (Enhancement)

This requirement is about ranking your business systems by how much they could affect the organisation if something went wrong, so you know where security work should be focused first. If you treat all systems as only broadly low, medium, or high impact, you may spend time and money in the wrong areas—either leaving the most serious weaknesses insufficiently protected or spending too much where it is not needed.

To meet this expectation, the organisation must review and prioritise all in-scope systems based on their impact level. Use the impact category already assigned to each system as the starting point, and then break any low/medium/high categories into smaller sub-groups when more detail is needed to make better, risk-based decisions.

The outcome must be recorded in the organisation’s security categorisation records and reflected in system planning documents. Named responsibility must be assigned to the people who carry out the work. The prioritisation must then be used to decide where to invest in security and how to adjust security measures accordingly.

##### Impact-level prioritisation with sub-category matrix for each system

- Category: Manual
- Priority: High

###### WHAT
Set up an impact-level prioritisation process that starts with each system’s existing Federal Information Processing Standards (FIPS) 199 “high-water mark” impact category (low, moderate, or high). Where more detail is needed to make risk-based decisions, split systems into more specific sub-categories (for example: low–moderate, moderate–moderate, high–moderate; low–high, moderate–high, high–high). Record these results in the organisation’s security categorisation records, and make sure they are used to choose and tailor security controls and to prioritise security spending.

###### WHY (control requirement)
The requirement RA-2(1) enhancement asks the organisation to perform impact-level prioritisation to add more detail to system impact levels. It must use the existing system impact categorisation as the baseline (the “high-water mark” concept) and produce sub-categories that support risk-based security control selection and tailoring.

###### HOW (specific steps/approach)
1. **Define sub-category criteria** in a standard procedure that aligns to the initial low/moderate/high categorisation. Use objective factors that fit the application context, such as: whether the system holds regulated or confidential data, how many downstream users or services rely on it, exposure and interaction patterns (for example, internet-facing application programming interfaces (APIs)), concentration of privileged or administrative functions, and whether the system combines multiple high-impact data types or processes.
2. **Create and maintain an “Impact Partitioning Matrix”** that links each initial impact category to the possible sub-categories (including a “no split” option when extra detail is not needed). Make sure the matrix clearly explains how each sub-category is derived from the initial category.
3. **Apply the matrix to every in-scope system** in the authoritative system inventory (including production, test, and disaster recovery (DR) systems where these are treated as separate systems in your categorisation records). For each system, record: the initial category, the chosen sub-category (or “no split”), evidence pointers showing how the high-water mark basis was determined, and the decision rationale.
4. **Use sub-categories to drive downstream security decisions** by updating each system’s security plan (and any privacy plan where applicable) to reference the sub-category and the resulting security control baseline and tailoring approach. This should also set the investment focus (for example, which control baseline set is used and what tailoring rules are allowed for that sub-category).
5. **Set review timing and triggers** in the procedure (for example, at least annually, and whenever changes could affect impact detail), such as new regulated data types, new external information exchanges, major integration changes, changes to the privilege model, or migration that changes how data is aggregated or how exposed the system is.

###### WHO (role responsible)
- **System Owner / Application Security Owner**: responsible for completing the prioritisation for their systems and providing evidence.
- **Information Security Governance (GRC) Lead**: maintains the matrix and procedure, checks for consistent application, and ensures results are recorded in security categorisation records.
- **Risk/Compliance Committee (or delegated governance forum)**: approves exceptions where the sub-category criteria are unclear or where “no split” is selected.

###### Acceptance criteria
- Impact-level prioritisation outcomes are recorded for **100% of in-scope systems**, starting from the existing low/moderate/high categorisation.
- Where additional detail is required, sub-categories are assigned using the defined matrix (or documented as “no split” with a rationale).
- Each system’s security plan (and privacy plan where applicable) references the assigned sub-category and the resulting security control baseline/tailoring and security investment focus.
- Evidence pointers and decision rationales are in place to support auditability.
- Review cadence and change-trigger rules are documented and applied, with records of the most recent review for each system.

###### Actions Required for Compliance

- [ ] Publish an **Impact Partitioning Matrix** procedure that sets sub-category criteria based on the existing **low / moderate / high** impact categorisation.
- [ ] Use the matrix for every in-scope system and record the initial category, the selected sub-category (or note that no split was used), where the supporting evidence can be found, and the reason for your choice.
- [ ] Update each system security plan and privacy plan to name the relevant sub-category, and to set out the resulting security control baseline (and any tailoring) and the investment priorities.
- [ ] Set up and carry out a regular review schedule, and define clear triggers for when re-partitioning is needed (for example: new regulated data, new external data exchanges, major system integrations, or changes to the way permissions and access privileges are managed).
- [ ] Carry out governance checks to confirm the rules are applied consistently across information technology (IT) and any relevant operational technology (OT) or other critical environments.


---

### RA-3 — Risk Assessment (Control)

This expectation is about making sure the organisation regularly works out what could realistically go wrong with a system and the personal information it handles, and then uses that understanding to make sensible decisions. Without this, weaknesses might be missed, harm could be underestimated, and the organisation could end up investing in the wrong fixes or leaving serious risks unaddressed, including risks to individuals such as identity theft or financial loss.

The organisation must carry out an ongoing risk assessment that:
- identifies threats and weaknesses
- estimates how likely different kinds of harm are and how severe they would be
- separately considers the impact on individuals when personal data is processed

It must then combine these findings with risk decisions made from both organisational and business-process perspectives. The organisation must record the results in a Risk Assessment Report, review it every 90 days, and share the results with the Authorising Official, the Chief Information Security Officer, the system owner, and the mission or business process owners. It must also update the assessment at least annually and whenever significant changes occur to the system or its operating environment.

##### RA-3 living risk assessment with privacy and governance workflow

- Category: Manual
- Priority: Critical

###### WHAT
Set up an ongoing, documented risk assessment process for the application that:
- Identifies threats and weaknesses (including dependencies/“related information” and external parties such as contractors and service providers).
- Estimates how likely problems are and how serious the impact would be (including the level of harm to organisational operations/assets and to individuals).
- Assesses privacy risks to individuals separately when personal data is processed.
- Produces and maintains a **Risk Assessment Report (RA-3)** that records threats, weaknesses, likelihood, impact, and **risk decisions**.
- Reviews results on a fixed schedule and updates the assessment when significant changes happen.

###### WHY (control requirement)
RA-3 requires an **ongoing risk assessment** that considers threats, weaknesses, likelihood, and impact to organisational operations/assets and individuals/other organisations/the Nation, and also considers risk from **external parties**. It must be carried out throughout the system development life cycle, documented in an RA-3 report, and **reviewed and updated** at defined intervals.

###### HOW (specific steps/approach)
1. **Define the RA-3 scope and boundaries** for the application across environments (production/test/disaster recovery) and clearly map “related information”, such as identity services, logging/security information and event management (SIEM), backup/restore, remote access, application programming interfaces (APIs)/integrations, and third-party/contractor-operated components.
2. **Create a structured threats and weaknesses register** for the application, using authoritative sources (for example, outputs from vulnerability management, findings from configuration baseline checks, penetration test results, and relevant threat intelligence/observed detections). Make sure each item links to supporting evidence and to the affected asset/data flow.
3. **Rate likelihood and impact** using organisation-approved rating scales, and record why each rating was chosen. Impact must cover confidentiality/integrity/availability consequences and the level of harm, including impacts to individuals.
4. **Carry out a privacy risk assessment** by linking categories of personal data (from data classification/discovery) to threat scenarios (for example, unauthorised disclosure, unauthorised alteration, disruption) and recording privacy-specific harms to individuals (for example, identity theft, financial loss), along with likelihood/impact.
5. **Include business and mission risk decisions** in the RA-3 process: record risk acceptance, risk treatment, and prioritisation decisions from mission/business process owners, and document how these decisions affect the overall system risk position and the choice of risk treatments.
6. **Maintain an auditable RA-3 report** (the required document) that includes: threats, weaknesses, likelihood, impact, privacy harms, and risk decisions, with reasons and evidence links.
7. **Hold governance review checkpoints**: carry out a formal review **every 90 days** with the Authorising Official, Chief Information Security Officer (CISO), system owner, and mission/business process owners. Update the RA-3 **annually** and also when significant changes occur (for example, architecture changes, major dependency changes, new data types/personal information (PII), major vendor/contractor changes, or material changes in how effective controls are).

###### WHO
- **System Owner**: responsible for the RA-3 content and ensuring it reflects the application’s current design and operating environment.
- **CISO / Information Security Risk Lead**: ensures the approach, rating scales, and evidence quality are consistent and approved.
- **Authorising Official**: receives the results and confirms the risk decisions are acceptable.
- **Mission/Business Process Owners**: provide input on business-process impacts and take part in the 90-day review.
- **Privacy Officer/Data Protection Lead (where applicable)**: checks that privacy risk assessment outputs and harms to individuals are valid.

###### Acceptance criteria
- An RA-3 report exists for the application and, as a minimum, includes documented **threats, weaknesses, likelihood, impact, privacy harms (where personal data is processed), and risk decisions**.
- The RA-3 is reviewed **every 90 days**, and the review outcomes are shared with the **Authorising Official, CISO, system owner, and mission/business process owners**.
- The RA-3 is updated **annually** and also when **significant changes** occur; evidence showing what changed is recorded.
- The assessment explicitly includes risk from **external parties** (contractors/service providers/outsourcing organisations) and documents how dependencies/“related information” were considered.
- Evidence links (for example, vulnerability findings, test results, data classification outputs) support the likelihood/impact ratings and the risk decisions.

###### Actions Required for Compliance

- [ ] Define the scope for RA-3 and clearly document the system boundaries and any “related information” dependencies, including identity, logging and security information and event management (SIEM), backup and restore, integrations, and third parties.
- [ ] Create and keep an auditable record of known threats and vulnerabilities for the application and its external-party components, including links to supporting evidence.
- [ ] For each threat or vulnerability scenario, calculate and record a likelihood rating and an impact rating, including how much harm it could cause to the organisation’s objectives and to individuals.
- [ ] Complete the privacy risk assessment by linking each type of personal data to possible threat situations, and record any potential harm to individuals, including how likely it is to happen and how severe the impact would be.
- [ ] Record the risk decisions (accept, treat, or mitigate) and the reasons for those decisions in the RA-3 report, using risk information from the mission and business process.
- [ ] Arrange and carry out formal RA-3 reviews every 90 days with the Authorising Official, the Chief Information Security Officer (CISO), the system owner, and the owners of the mission or business processes. Keep the evidence of each review.
- [ ] Review and update RA-3 every year. If there are significant changes, make an update outside the normal schedule. Record what triggered the change and document the differences made.


---

#### RA-3.1 — Supply Chain Risk Assessment (Enhancement)

This requirement is about making sure the organisation understands the risks that can come from suppliers and other third parties before and during the lifetime of the on-premises systems that run both information technology (IT) and operational technology (OT). If these supply chain risks are ignored, issues such as delayed deliveries, faulty or counterfeit parts, theft, or even intentionally harmful software could be introduced. This could lead to loss of service, disruption to operations, and harm to the organisation’s reputation and people.

To meet this expectation, the organisation must first identify and cover all in-scope systems, components, and services used for on-premises mixed IT/OT operations. It must then carry out a supply chain risk assessment for each one and record the results so they can be reviewed later. The assessment must be updated at least every 12 months, and within 30 days whenever there is a significant change to suppliers, components, deliveries, the system, its operating environment, or other conditions that could affect the risk.

The organisation must define what counts as a significant change, keep clear records of reviews and updates, and share the assessment outcomes with the relevant people who are responsible for taking action.

##### Inventory-linked supply chain risk register with 30-day trigger updates

- Category: Software
- Priority: Critical

###### WHAT
Set up an inventory-linked supply chain risk register for all in-scope on-premises mixed information technology (IT) and operational technology (OT) systems, components, and system services. For each item, record a documented risk assessment and the actions needed to reduce those risks. Update these assessments **at least once every year** and **within 30 days** after any significant supply chain or system/environment change.

###### WHY (control requirement)
The control requirement RA-3(1) enhancement guidance says the organisation must carry out and document supply chain risk assessments for **systems, system components, and system services**, and keep them **up to date**. This includes recognising supply chain events such as disruption, faulty components, counterfeit items, theft, harmful development practices, poor delivery practices, and the insertion of malicious code.

###### HOW (specific steps/approach)
1. **Define and maintain scope**: Create an authoritative, audit-ready inventory covering all in-scope on-premises mixed IT/OT systems, components, and services used to run the organisation’s operations.
2. **Create a per-item risk assessment record**: For each inventory item, record supplier or service provider details, component or service identifiers (including version or build where relevant), delivery and maintenance arrangements, and the resulting supply chain risk assessment outcome (the risks identified and the required actions or decisions).
3. **Use a standard assessment template**: Use one consistent template aligned to supply chain event types (disruption, faulty components, counterfeit items, theft, harmful development, poor delivery, malicious code). This ensures every item has comparable evidence and conclusions.
4. **Automate evidence capture where possible**: Add supplier-provided documents and security information to the register (for example, software bill of materials (SBOMs) or artefact metadata, signed build origin information where available, vendor security alerts, end-of-support dates, and statements relevant to secure development practices). Link this evidence to the specific inventory item.
5. **Set “significant change” triggers and a clear process**: Define what counts as a significant change (for example, a new supplier or contractor, a major version or build change, a vendor security alert rated High/Critical, evidence suggesting counterfeit or faulty component risk, a change to delivery or maintenance method, or any system/environment change that affects the item’s supply chain risk). When a trigger occurs, start a reassessment process with a service-level agreement (SLA) to complete and approve the update **within 30 days**.
6. **Enforce timing and auditability**: Configure the register so reassessments are required **at least once every year** and so it keeps a clear history of reviews (who reviewed, when, what evidence was used, what changed, and what actions or decisions were updated). Make sure the results are shared with the roles responsible for acting on the mitigations (for example, procurement, engineering, and security governance).

###### WHO (role responsible)
- **Information Security / Supply Chain Risk Owner**: Owns the risk register, the assessment template, the trigger definitions, and the governance process.
- **Application / Infrastructure / OT Engineering Leads**: Provide item-level technical context and confirm the actions needed to reduce risk.
- **Procurement / Vendor Management**: Provide supplier, contract, delivery, and maintenance details, and ensure supplier evidence is requested and kept.
- **Compliance / Internal Audit (or assurance function)**: Periodically checks the quality of evidence and whether updates are completed on time.

###### Acceptance criteria
- The organisation has an authoritative inventory covering all in-scope **systems, components, and system services** used for on-premises mixed IT/OT operations.
- For each in-scope inventory item, there is a documented supply chain risk assessment record that includes identified supply chain risks and documented actions or decisions to mitigate them.
- The register shows that assessments are updated **at least once every year**.
- The register shows that when a defined significant-change trigger occurs, the related assessment is updated and approved **within 30 days**.
- Evidence used for assessments is linked to the relevant inventory item, and review history is retained (reviewer, date, evidence, and changes).
- Risk assessment results are shared with the responsible roles needed to implement the mitigations.

###### Actions Required for Compliance

- [ ] Create and get approval for an official inventory of all in-scope on-premises mixed information technology (IT) and operational technology (OT) systems, components, and system services.
- [ ] Set up a supply chain risk register using a standard template to assess each item, covering all required supply chain event categories.
- [ ] Define and document the “significant change” triggers that require reassessment, and link each trigger to the relevant inventory item.
- [ ] Set up automated collection of evidence (for example, software bill of materials (SBOM) and file details, supplier security updates, end-of-support dates, and signed statements) and attach the relevant evidence to each item in the inventory.
- [ ] Set service level agreements (SLAs) for the workflow so that reassessments happen at least once every year and within 30 days of the trigger being activated, with approval from the reviewer.
- [ ] Set clear rules for sharing risk assessment results and the required mitigation actions with the procurement, engineering, and security governance teams.
- [ ] Check that the audit is ready by preparing sample proof that shows the review dates, where the evidence came from, the risk decisions made, and the latest updates to the mitigation actions.


---

#### RA-3.2 — Use of All-source Intelligence (Enhancement)

This requirement is about using a wide range of reliable information to identify and understand risks before they cause harm. Without it, an organisation may miss important weaknesses, whether they come from how something is designed and made, how products are delivered, the people involved, or the wider environment—and whether those weaknesses are intentional or accidental.

To meet this expectation, the organisation must build this approach into its risk assessment and planning by using clear, written procedures for gathering, selecting, and using relevant information from multiple sources. This must include publicly available information and at least one other type of evidence, such as internal test results, supplier information, observations, or incident history. The organisation must assign responsibility to named people, carry out risk analysis using this evidence, and keep documented records of the findings, reviews, and any updates, supported by risk intelligence reports.

Where suppliers are involved, the organisation must also use this evidence-based approach to manage supplier risks, including key sub-suppliers where needed, and record how decisions and actions were informed.

##### Evidence-graph workflow linking all-source intelligence to risk

- Category: Software
- Priority: High

###### WHAT
Set up an “evidence graph” that connects the organisation’s risk assessment results to the specific intelligence evidence used. This should be built into the organisation’s risk management process.

###### WHY (control requirement)
NIST RA-3(2) enhancement requires that risk analysis is supported by **all-source intelligence**, meaning information taken from **all available sources**, including **open/public information** and other intelligence types (for example: measurements/signatures, human information, signals, and imagery). The guidance also requires using this intelligence to assess risks from vulnerabilities across **development, manufacturing, delivery, people, and the environment**. This includes both **intentional** and **unintentional** vulnerabilities. Where relevant, it must also support supplier risk analysis.

###### HOW (specific steps/approach)
1. **Define an intelligence evidence structure and categories** for use in the risk process. Include mandatory fields for: source type (at minimum **open/public** plus at least one other technical/observational type), lifecycle area (development/manufacturing/delivery/people/environment), vulnerability category, and an intentional/unintentional label.
2. **Bring in and standardise intelligence items** into a controlled internal repository (for example, a governance, risk, and compliance (GRC) integrated data store). Use deduplication keys (component/version/common vulnerability and exposure (CVE)/asset identifiers) and keep provenance details (where it came from, date, and notes on confidence/validity).
3. **Set up the risk assessment workflow** so that, for each risk record, the risk owner must attach at least **two evidence items**: one from **open/public** sources and one from a **non-open technical/observational** source (for example, internal test results, vulnerability scan findings, incident or field observations, or supplier quality/audit findings). The workflow must also record how the evidence was used to determine likelihood and impact, and the resulting risk treatment.
4. **Maintain traceability and review records**: store the intelligence basis, the reasoning for any changes to likelihood/impact, the choice of mitigation (and any changes), what triggered the review, and the date the evidence was used. Ensure that when risks are reviewed and updated, the evidence links remain.
5. **Apply the same evidence-graph approach to supplier risk**: when assessing suppliers (including key sub-suppliers), require evidence attachments that link to supplier lifecycle risks (for example, delivery/manufacturing processes, people/process controls, and relevant environment factors). Record how the intelligence informed the supplier risk decisions.

###### WHO (role responsible)
- **Information Security / Risk Management Lead**: owns the evidence structure, workflow requirements, and governance.
- **GRC Platform Owner / Security Engineering**: builds the evidence repository, configures the workflow, and manages integrations.
- **Risk Owners (Application/Engineering/Supply Chain)**: carry out risk analysis using the attached all-source intelligence evidence and document their reasoning.
- **Third-Party/Supplier Risk Manager**: ensures supplier and sub-supplier assessments follow the same evidence-graph requirements.

###### Acceptance criteria
- For a sample set of completed risk assessments, each risk record includes **documented evidence links** to at least one open/public intelligence item and at least one other technical/observational intelligence item.
- Evidence links are mapped to the relevant **lifecycle areas** (development/manufacturing/delivery/people/environment) and include an **intentional/unintentional** classification where applicable.
- Risk decisions (likelihood/impact and treatment) can be traced back to the attached intelligence evidence, and evidence links remain through **risk reviews/updates**.
- Supplier risk assessments (including key sub-suppliers, where used) show the same evidence traceability and reasoning.
- Audit evidence shows that the workflow enforces the requirements above (for example, required fields, validation checks, and retained records).

###### Actions Required for Compliance

- [ ] Create a standard way to record intelligence evidence for risk assessments, including: the type of source, the stage of the activity it relates to, whether the impact was intentional or unintentional, and the category of vulnerability.
- [ ] Set up a controlled intelligence repository that records where each item came from (provenance metadata) and avoids duplicates by using the component name, version, Common Vulnerabilities and Exposures (CVE) identifier, and asset identifier.
- [ ] Set up the governance, risk and compliance (GRC) workflow so that each risk record must include at least one open or public evidence item and at least one non-open evidence item based on technical or observational information.
- [ ] Add mandatory traceability fields that record how the evidence was used to decide the likelihood and impact, how it informed the choice of mitigations, and what review triggers apply.
- [ ] Where appropriate, include supplier risk assessments in the same evidence-graph workflow used for key sub-suppliers.
- [ ] Run a trial using typical application and supplier risks, and check that the completed risk records include evidence that is ready for audit and can be traced back to the source.


---

#### RA-3.3 — Dynamic Threat Awareness (Enhancement)

This requirement is about keeping a current, live view of the cyber attacks that are most likely happening now, rather than relying on older assumptions. Without this ongoing awareness, the organisation could miss early warning signs, misjudge how quickly attackers are taking advantage of newly found weaknesses, and keep its everyday security rules the same even as the threat level increases—making successful break-ins more likely.

To meet this expectation, the organisation must regularly review the current threat environment on an ongoing basis using three inputs: up-to-date threat information from external sources, information about newly discovered or currently used weaknesses, and active checks for warning signs that an attack may already be underway. The findings must be shared with the information security operations team so that procedures are updated when the threat level changes, including adjusting access and login expectations where appropriate.

This approach must be documented in planning, with responsibilities assigned, outcomes recorded, reviewed, and updated over time, and with evidence kept.

##### Automated threat environment fusion feeding security ops

- Category: Software
- Priority: Critical

###### WHAT
Set up an ongoing, automated assessment of the “current threat environment” that continuously determines the cyber threats facing the organisation by using: (1) threat intelligence feeds, (2) vulnerability intelligence, and (3) active monitoring of indicators of compromise. Use the resulting threat level to update information security operations, so that procedures and (where defined) privilege and authentication thresholds can be adjusted.

###### WHY (control requirement)
NIST SP 800-53 **RA-3(3)** enhancement requires the organisation to **determine the current cyber threat environment on an ongoing basis using the specified means** (parameter **ra-03.03_odp: means** = “threat intelligence feeds, vulnerability intelligence, and active monitoring of indicators of compromise”). Guidance also requires that the organisation’s threat awareness **feeds into information security operations**, so procedures are updated as the threat environment changes (for example, tightening or loosening privilege or authentication thresholds when threat levels rise).

###### HOW (specific steps/approach)
1. **Define threat levels and link them to operational actions**: Create a documented mapping from threat level (for example, Low/Guarded/Elevated/Critical) to specific changes in security operations (for example, stronger authentication requirements, multi-factor authentication (MFA) assurance level, stricter privileged access approval, and increased monitoring escalation). Make sure this mapping is approved through the organisation’s change and governance process.
2. **Bring in and standardise the three required inputs**:
   - Ingest **threat intelligence feeds** (for example, Structured Threat Information Expression (STIX) / Trusted Automated eXchange of Indicator Information (TAXII), or supplier application programming interfaces (APIs)) into the enterprise threat intelligence platform or the security information and event management (SIEM) enrichment layer.
   - Ingest **vulnerability intelligence** focused on weaknesses that are actively being exploited (for example, supplier advisories, exploitability scoring similar to Exploit Prediction Scoring System (EPSS), known exploited lists) and standardise it to Common Vulnerabilities and Exposures (CVE) / Common Platform Enumeration (CPE) and asset-relevant information.
   - Ensure **active monitoring of indicators of compromise** by enabling security information and event management (SIEM), endpoint detection and response (EDR), extended detection and response (XDR), and relevant log sources for authentication events, endpoint detections, proxy and domain name system (DNS), email security, and cloud audit logs as applicable.
3. **Continuously combine and assess the signals**: Build correlation logic that combines threat intelligence (TI), vulnerability intelligence (VI), and indicators of compromise (IoC) signals into a confidence-weighted view of the threat environment for the relevant scope (for example, by business unit, technology stack, or asset group). The output must include: which inputs were used, the reasoning/confidence, and the resulting threat level.
4. **Publish an auditable threat environment bulletin**: On a defined schedule (and immediately when there are significant changes), produce a dated bulletin or ticket recording the assessment inputs used, the calculated threat level, and the recommended operational actions.
5. **Use the bulletin to update security operations and trigger procedure changes**: Integrate the bulletin output with security orchestration, automation and response (SOAR) or workflow tooling so that when the threat level changes, security operations procedures are updated through controlled actions (for example, enforcing stronger authentication for specified user groups, tightening privileged access workflows, and increasing monitoring and alerting thresholds). If system configuration changes are needed, route them through the organisation’s standard change management process.
6. **Keep evidence and review effectiveness**: Keep the logs, bulletins, correlation outputs, and workflow outcomes. Carry out periodic reviews of correlation tuning and the threat-level-to-action mapping to ensure it remains effective as the environment changes.

###### WHO (role responsible)
- **Cyber Threat Intelligence Lead / Security Operations Centre (SOC) Lead**: owns the threat level logic, correlation tuning, and bulletin content.
- **Security Operations (SOC) Manager**: owns the operational mappings and the triggers for procedure updates.
- **Security information and event management (SIEM) / security orchestration, automation and response (SOAR) Engineer**: implements ingestion, standardisation, correlation, and workflow integrations.
- **Information Security Governance / Risk Owner**: approves threat-level mappings and ensures procedure updates align with risk appetite and change governance.

###### Acceptance criteria
- The system produces an **ongoing** threat environment assessment using **all three required means** (threat intelligence feeds, vulnerability intelligence, and active indicators of compromise monitoring) and records evidence of each input used for each assessment output.
- The assessment output is **fed into information security operations** so that threat level changes result in **documented procedure updates**.
- For at least one defined threat level escalation, the workflow demonstrably updates **privilege and/or authentication thresholds** (or the organisation’s equivalent operational controls) according to the approved mapping.
- Evidence is retained for audit: bulletins or tickets, correlation reasoning/confidence, workflow actions taken, and timestamps.
- The schedule and trigger conditions are implemented and tested (for example, scheduled runs and immediate updates when significant changes occur).

###### Actions Required for Compliance

- [ ] Set out the threat levels and approve a clear mapping from each threat level to the operational actions to take, including any changes to privilege and authentication thresholds.
- [ ] Set up the collection and standardisation of threat intelligence feeds, vulnerability intelligence, and the required log sources so that active indicators of compromise (IoC) monitoring can run.
- [ ] Set up continuous monitoring that brings together threat intelligence (TI), vulnerability information (VI), and indicators of compromise (IoC) to produce a threat view, where each risk is weighted by confidence.
- [ ] Automate the creation of a dated, auditable threat bulletin or ticket that records the information used and the resulting threat level.
- [ ] Link bulletin updates to security orchestration, automation and response (SOAR) workflows so that security procedures are updated in a controlled way whenever the threat level changes.
- [ ] Test and confirm that at least one escalation scenario changes the privilege and authentication limits and generates stored evidence.


---

#### RA-3.4 — Predictive Cyber Analytics (Enhancement)

This requirement is about using smart, automated analysis to identify likely security problems before they fully develop. It involves continuously reviewing information from your main information technology services, your operational technology network areas, and your on-site security monitoring tools. Without this, your security team can be overwhelmed by too much data and may only notice attacks after damage has occurred, or miss early warning signs that unusual behaviour is building up.

To meet this expectation, the organisation must:
- define where these predictive analytics apply;
- ensure the relevant data keeps flowing;
- use learning-based analytics to find and connect suspicious patterns, detect unusual behaviour, and calculate forward-looking risk levels; and
- include structured analysis that links findings to known attacker behaviours.

Any automated actions must adjust based on the surrounding context. However, people must review the system’s conclusions before any high-impact steps are taken. This must be supported by clear records, regular reviews, and updates when the analytics or its inputs change, so risk reports can be shared with the right decision-makers.

##### ML predictive risk scoring with human-gated SOAR workflows

- Category: Software
- Priority: Critical

###### WHAT
Set up predictive cyber analytics that use machine learning–assisted threat discovery and correlation to forecast and identify risks across the defined **systems or system components** (enterprise IT services, operational technology (OT) network segments, and on-premises security monitoring sensors). Send the results into **adaptive response workflows** that analyse the situation using context and require **human approval** (human-in-the-loop) for any high-impact actions.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **RA-3(4)** enhancement requires: “Employ advanced automation and analytics capabilities to predict and identify risks to {{ param, ra-03.04_odp.02 }},” including advanced automation and analytics (often machine learning), adaptive workflow operations, and **human monitoring**. This is necessary because attackers may retrain models to make malicious activity look harmless.

###### HOW (specific approach)
1. **Define the analytics scope and risk outputs** for the organisation’s defined targets:
   - Enterprise IT services, OT network segments, and on-premises security monitoring sensors.
   - Define the predictive outputs (for example: risk score, predicted technique/tactic candidates, affected entities, confidence level, and contributing signals).
2. **Build a correlation and predictive analytics layer**:
   - Collect data (telemetry) from the relevant sources into a single analytics pipeline.
   - Use **behaviour-based anomaly detection** (baseline normal behaviour for users, devices, processes, and networks) and convert anomalies into **predictive risk scoring**.
   - Use **machine learning–assisted threat discovery and correlation** to link entities and events into likely stages of an attack.
3. **Align analytics to the MITRE ATT&CK framework**:
   - Match correlated clusters and predicted technique candidates to MITRE ATT&CK tactics and techniques.
   - Store MITRE ATT&CK identifiers in case records so analysts can review “why” the system believes a risk is developing.
4. **Create adaptive response workflows (SOAR-style)** with context-based analysis:
   - Add context to each predicted risk (asset importance, service ownership, OT zone/conduit, maintenance windows, identity security posture, and safety/operational limits).
   - Automatically carry out **low-impact** actions (for example: extra enrichment, creating tickets, expanding logging), but **require analyst approval** for **high-impact** containment actions (for example: isolating endpoints, disabling accounts, blocking OT activity).
5. **Human-in-the-loop monitoring and evidence**:
   - Require analyst review for high-impact actions and for cases above a defined risk threshold.
   - Record the contributing signals, model version, and MITRE ATT&CK mapping used for each decision to support auditability and analyst checks.
6. **Make continuous improvement operational**:
   - Set a schedule for updating and retraining, and a process to refresh models and analytics when inputs or the environment change.
   - Watch for model “drift” and attempts by attackers to reduce detection confidence; escalate to analysts when confidence drops or patterns no longer match expectations.

###### WHO
- **Security Operations Centre (SOC) / Computer Incident Response Team (CIRT) Lead**: responsible for workflow design, analyst approval thresholds, and review procedures.
- **Security Analytics Engineer / Data Scientist**: builds machine learning–assisted correlation, anomaly detection, predictive scoring, and MITRE ATT&CK mapping.
- **Security Orchestration, Automation and Response (SOAR) / Automation Engineer**: builds adaptive workflows and integrations.
- **Operational Technology (OT) Security Engineer (where applicable)**: confirms OT-specific context limits and safe automation boundaries.
- **Information Security Governance / Risk Owner**: approves risk thresholds and ensures outputs are shared with decision-makers.

###### Acceptance criteria
- Predictive risk scoring and identification of emerging risks work for the defined scope: **enterprise IT services, OT network segments, and on-premises security monitoring sensors**.
- Analytics include **behaviour-based anomaly detection** and **machine learning–assisted threat discovery/correlation**, producing a forward-looking risk score.
- Each high-confidence prediction is **aligned to the MITRE ATT&CK framework**, with stored tactic/technique identifiers and evidence of contributing signals.
- Adaptive response workflows carry out **context-based analysis** and enforce **human approval** for high-impact actions.
- For every action taken (especially actions requiring approval), the system produces audit-ready evidence: contributing signals, model version, risk score, MITRE ATT&CK mapping, and the analyst’s decision record.

###### Actions Required for Compliance

- [ ] Define the scope for predictive analytics across enterprise information technology (IT) services, operational technology (OT) network segments, and on-premises security monitoring sensors.
- [ ] Use machine learning to help find threats and link related events, using combined system data to produce predictive risk scores
- [ ] Add behavioural anomaly detection, then turn detected anomalies into forward-looking risk scores with confidence levels.
- [ ] Link related or predicted findings to the MITRE ATT&CK tactics and techniques, and record the MITRE ATT&CK identification numbers (IDs) in the case records.
- [ ] Set up adaptive response workflows that add useful context and automatically carry out only low-impact actions.
- [ ] Require a human to approve high-impact containment actions, and record the analyst’s decisions with supporting evidence.
- [ ] Set a regular schedule for updating and retraining the model, and monitor for performance drift and attempts to bypass it, with clear escalation thresholds.


---

### RA-5 — Vulnerability Monitoring and Scanning (Control)

This requirement is about finding known security weaknesses in your systems early, before criminals can take advantage of them. If checks are not done regularly, problems in software, system settings, or newly updated components can go unnoticed. This can create gaps that may lead to data loss, disruption to services, or unauthorised access.

To meet this expectation, the organisation must check hosted applications and on-premises system components every week. It must also run checks immediately after any patch or firmware update for on-premises components, and after any code or configuration change for hosted applications. In addition, it must carry out random scans once every month.

The organisation must use tools and methods that work well together. These tools must be able to be updated quickly when new weaknesses are discovered, and they must be able to automatically identify what is affected, use consistent test checklists, and estimate the likely impact.

The organisation must review the results of each scan and fix genuine issues within risk-based timeframes: Critical within 7 days, High within 15 days, Medium within 30 days, and Low within 60 days. It must also share the findings with the Chief Information Security Officer (CISO) and the vulnerability management team, so similar problems can be prevented elsewhere.

##### SCAP/OVAL weekly + change-triggered vulnerability scanning with SLA triage

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated capability to monitor for and scan vulnerabilities in both (1) on-premises system components and (2) hosted application components. Run it on the organisation’s defined schedules and also immediately after relevant changes. The capability must use recognised vulnerability standards for identification and reporting (for example, **Common Vulnerabilities and Exposures (CVE)**, **Common Weakness Enumeration (CWE)**, **National Vulnerability Database (NVD)**, and where applicable **Security Content Automation Protocol (SCAP)** / **Open Vulnerability and Assessment Language (OVAL)**). It must also be able to update scanning tools and content quickly.

###### WHY (control requirement)
**Risk Assessment (RA)-5** requires vulnerability monitoring and scanning to be carried out at a defined frequency and depth. It must cover the most likely sources of vulnerabilities, including infrastructure components and hosted applications, and it must support timely updates to monitoring tools when new vulnerabilities and new scanning approaches are announced. It also requires vulnerability monitoring to include checks for patch levels and for exposed or accessible functions, ports, protocols, and services. Results must be analysed so that genuine vulnerabilities are fixed within organisation-defined, risk-based response times.

###### HOW (specific steps/approach)
1. **Define scan scope and profiles**: Create separate scan profiles for (a) on-premises system components (infrastructure components) and (b) hosted applications. Assign each in-scope asset to the correct profile and to a remediation service level agreement (SLA) band (Critical/High/Medium/Low) using the organisation’s defined response times.
2. **Use standards-based vulnerability identification**: Configure the scanning platform to identify vulnerabilities using **CVE** naming, and use **OVAL/SCAP-validated** checks where available. Make sure scan results include consistent vulnerability identifiers and severity/impact measures (for example, values derived from **Common Vulnerability Scoring System (CVSS)**) to support triage.
3. **Automate scheduling to match organisation-defined parameters**:
   - Run **weekly** vulnerability monitoring for **hosted applications** and **on-premises system components**.
   - Run **immediate scans after patch or firmware updates** for on-premises components.
   - Run **immediate scans after any code or configuration change** for hosted applications.
   - Run **random monthly scans** by selecting a deterministic random group from the in-scope asset list and recording how the group was chosen for audit purposes.
4. **Route scan results through a triage-to-fix process**: Automatically send scan results into the vulnerability management process, perform initial analysis (including handling false positives), and send confirmed genuine vulnerabilities to remediation work orders with supporting evidence (scan report, affected components, CVE, and calculated impact). Ensure fix targets match the organisation’s defined response times: **Critical 7 days, High 15 days, Medium 30 days, Low 60 days**.
5. **Ensure the ability to update tools and scanning content**: Put in place an operational process to update vulnerability monitoring tool content/definitions promptly when new vulnerabilities are announced and when scanning methods change. Record update times and content versions for audit evidence.
6. **Share outcomes with required roles**: Provide automated reporting dashboards and scheduled summaries of scan findings, trends, and any SLA breaches to the **Chief Information Security Officer (CISO)** and the vulnerability management team.

###### WHO
- **Vulnerability management team**: Own scan profile design, scheduling rules, triage workflow, and routing of remediation work orders.
- **CISO**: Receives reporting, reviews SLA performance, and reviews risk acceptance decisions.
- **Change management owner / release manager**: Ensures patch/firmware and code/configuration change events trigger the correct scan runs.
- **Security engineering / IT operations**: Keeps the scanning platform available, manages access controls, and maintains the update process.

###### Acceptance criteria (verifiable)
- Weekly scans are run for all in-scope hosted applications and on-premises system components, and results are kept as audit evidence.
- Scans are carried out **after** on-premises patch/firmware updates and **after** hosted application code/configuration changes, with evidence linking the scan run to the change event.
- Random monthly scans happen at least once per month using a logged random group selection method.
- Scan outputs consistently include **CVE identifiers** and severity/impact measures; where applicable, checks are **SCAP/OVAL-based**.
- Confirmed genuine vulnerabilities are fixed within the organisation-defined SLAs (**Critical 7 days, High 15 days, Medium 30 days, Low 60 days**), or documented with an approved risk acceptance.
- Vulnerability monitoring tool/content updates are completed and logged with timestamps and content versions.
- Reports showing findings and SLA performance are provided to the **CISO** and the vulnerability management team on a defined schedule.

###### Actions Required for Compliance

- [ ] Create separate vulnerability scan profiles for on-premises system components and hosted applications. Then assign each asset to the correct profile and service level agreement (SLA) band.
- [ ] Set up the scanner to identify known vulnerabilities using Common Vulnerabilities and Exposures (CVE) information. Where supported, turn on Security Content Automation Protocol (SCAP) and Open Vulnerability and Assessment Language (OVAL) checks, and make sure the results include the CVE reference plus severity and impact measurements.
- [ ] Set up automated scanning to run every week for monitoring, and run additional random scans each month for selected cohorts, with the cohort selection recorded in logs.
- [ ] Coordinate scan timing with change management so scans run right after on-premises patching and firmware updates, and right after hosted application code or configuration changes.
- [ ] Automate the upload of scan results into the vulnerability management process, and automatically create repair (remediation) tickets that include supporting evidence and the Common Vulnerabilities and Exposures (CVE) details.
- [ ] Set up and document a process for updating vulnerability tools and content, and record the date and time of each update along with the content version number.
- [ ] Set up regular reports to the Chief Information Security Officer (CISO) and the vulnerability management team showing security findings, trends, and whether service-level agreements (SLAs) are being met.


---

#### RA-5.2 — Update Vulnerabilities to Be Scanned (Enhancement)

This requirement is about making sure the list of known security weaknesses that your scanning tool checks for is always current before you start a new scan, and also whenever new weaknesses are discovered and reported. If you use an out-of-date list, you may miss newly found problems, which could give attackers an opportunity to exploit them before you have a chance to fix them or reduce the risk.

To meet this expectation, the organisation must update the vulnerability list before each new scan and whenever new vulnerabilities are identified and reported. Updates must happen at least weekly, even if there are no new items to add. The most recently updated list must be used for the next scan. The organisation must also keep clear records showing when the list was updated and the reason for each update.

Named individuals should be responsible for keeping the list up to date and for reviewing scan results. The overall scanning approach must be documented, so it is clear how updates are applied and how scan findings are tracked through to fixing the issues and any follow-up actions.

##### Automate vulnerability feed refresh and enforce pre-scan scan gate

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated process to refresh the vulnerability intelligence (the vulnerability list) used by the scanning tool **before every new scan**. Do this **at least weekly**, and also **immediately when new vulnerabilities are identified and reported**. Put in place a **scan gate** so scans cannot start unless the scanner is set to use the **most recently updated** vulnerability list. Keep proof (evidence) of each update.

###### WHY (control requirement)
NIST SP 800-53 **RA-5(2)** enhancement requires: “Update the system vulnerabilities to be scanned {{ insert: param, ra-05.02_odp.01 }}.” The organisation-defined parameter means updates are required **before a new scan**, and **when new vulnerabilities are identified and reported**. The guidance also stresses that newly discovered vulnerabilities must be added to the list of vulnerabilities to be scanned so they can be addressed quickly.

###### HOW (specific steps/approach)
1. **Choose and standardise the trusted sources** that supply the scanner’s vulnerability list (for example, vendor advisories and Common Vulnerabilities and Exposures (CVE) enrichment feeds). Configure the scanner to use its supported feed/update method.
2. **Create an automated feed refresh job** (for example, a scheduled job or continuous integration (CI) runner) that runs **at least weekly** (per the organisation-defined parameter **ra-05.02_odp.02 = weekly**). Capture evidence each time, including: feed name, feed version/hash, update time, and source/reason.
3. **Add an event-based trigger**: when new vulnerabilities are identified and reported (for example, through vendor advisory notifications, Computer Security Incident Response Team (CSIRT)/Computer Emergency Response Team (CERT) feeds, or vulnerability intelligence webhooks), trigger an **on-demand feed refresh**.
4. **Implement a scan gate in the scan coordination process**: before starting any scan, check that the scanner configuration points to the **latest available feed version** and that the last refresh meets the rules (weekly minimum, and “updated for the latest event” when triggered). If the checks fail, **block the scan** and alert the responsible role.
5. **Store audit evidence and connect it to scan runs**: keep an append-only record of each feed update and the scan details (scan identifier ↔ feed version/hash ↔ update time). This shows that the “most recently updated” list was used for the next scan.
6. **Assign named ownership and review**: set up workflow ownership (for example, tickets/approvals) so a named security engineer or vulnerability management lead is responsible for running and checking the feed updates, and for reviewing scan results and follow-up actions.
7. **Document the pre-scan gate and update process** in the system’s scanning runbook/system security plan, so auditors can see how updates are applied and how findings move towards remediation.

###### WHO (role responsible)
- **Vulnerability Management Lead / Security Engineer**: owns the scan gate policy, ensures the feed refresh workflow runs, and reviews evidence and scan results.
- **Platform/DevOps Engineer (Scanner Orchestration Owner)**: builds the automation, the scan gate checks, and the evidence logging.

###### Acceptance criteria
- For every scan run, evidence exists showing the vulnerability list/feeds were updated **before the scan**, and the scan used the **most recently updated** feed version.
- Feed refresh happens **at least weekly** during normal operation.
- When a new vulnerability is identified and reported, an on-demand refresh is triggered and finished before the next scan (or scans are blocked until the refresh completes).
- Scan orchestration enforces a **hard block** (no scan starts) when the feed version is not current under the gate rules.
- Audit records clearly link each scan run to the feed version/hash and update time.

###### Actions Required for Compliance

- [ ] Choose and set up how the scanner receives vulnerability updates, including the trusted, official sources it will use.
- [ ] Set up an automated job that refreshes the feed every week and records the feed version (or hash), the date and time, and the source and reason for the update.
- [ ] Set up event-based triggers so that feeds are updated immediately when new vulnerabilities are identified and reported.
- [ ] Add a “scan gate” to the scan orchestration process so that a scan cannot start unless the latest feed version is being used.
- [ ] Store audit evidence that can only be added to, linking every feed update to every scan run (scan ID ↔ feed version or hash ↔ time and date).
- [ ] Assign named responsibility for carrying out and checking feed updates, and for reviewing scan results, using the organisation’s workflow tools.
- [ ] Update the scanning runbook and system security plan to describe the pre-scan approval step (“pre-scan gate”) and the update schedule (weekly and also triggered by events).


---

#### RA-5.3 — Breadth and Depth of Coverage (Enhancement)

This requirement is about making sure your vulnerability scanning is neither too limited nor too superficial. You should search for known security weaknesses across the right parts of your systems, at the level where you can actually fix the issues. If you do not set clear coverage targets, important risks may be missed—for example, if some systems, types of systems, or the most critical areas are not scanned, or if the results are reported in a way that does not clearly show which specific part needs attention.

To meet this expectation, the organisation must define and document:
- how widely it will scan (for example, what proportion of components, which system types, and which criticality levels), and
- how deeply it will scan (for example, whether checks are carried out at component, module, or subsystem level).

The organisation must then ensure that the scanning tools can meet these targets, are configured to do so, and that the tool settings are documented. If one tool is not enough, additional tools must be used. The agreed scanning breadth and depth must be recorded in the vulnerability scanning assessment evidence.

##### Define and evidence vulnerability scan breadth/depth targets

- Category: Manual
- Priority: Critical

###### WHAT must be done
Set measurable **breadth** (how much of the system is scanned) and **depth** (what level of design the scan results are produced at) for vulnerability scanning. Then make sure the scanning tools’ scope and settings, and the way results are reported, actually meet those targets. Keep a record of the basis for adequacy and the evidence that coverage is achieved.

###### WHY (control requirement)
NIST RA-5(3) (Enhancement) requires the organisation to **define the breadth and depth of vulnerability scanning coverage**. The guidance explains that:
- **Breadth** can be expressed as a **percentage of components**, by **system type**, by **system criticality**, or by the **number of vulnerabilities to be checked**.
- **Depth** can be expressed as the **system design level** intended to be monitored (for example: component, module, subsystem, or element).
It also notes that **tool settings affect breadth and depth**, and that **more than one scanning tool may be needed**.

###### HOW (specific steps/approach)
1. **Create a Coverage Model** that links an authoritative asset or inventory source to what is scanned and how results are reported. The model must, at minimum, include asset/system type, environment (production, test, disaster recovery), and criticality tier.
2. **Set breadth targets** using at least one measurable method from the guidance (for example: % of components by criticality tier; scan all assets of specific system types; or define the vulnerability categories or counts to be checked). Include clear exceptions and compensating controls.
3. **Set depth targets** using system design levels (for example: host-level only for defined exceptions; otherwise map results to application components/modules where inventory, software bill of materials (SBOM), and service inventory exist; for microservices, require mapping to service/module identifiers).
4. **Match tool capabilities to the model**: document which types of scanners (for example: authenticated network/host scanning, web/application programming interface (API) scanning, container/image scanning, and software composition analysis (SCA) or dependency scanning) meet each breadth and depth requirement. If a tool cannot reach the required depth, add and/or configure additional tools to meet the model.
5. **Configure scanners to follow the model**: ensure scan profiles use inclusion and exclusion rules based on the inventory and criticality tiers, and that result identifiers can be traced back to the model’s design-level mapping.
6. **Keep scanner configuration records** for each scanner profile (frequency, authentication method and credential scope, ports and protocols, exclusions, and mapping rules that determine depth).
7. **Keep evidence for each scan cycle**: for every scan cycle, record (a) the breadth targets and the actual coverage achieved (for example: % of eligible assets scanned by tier/type), (b) the depth achieved (for example: what proportion of results are mapped to the required design level), (c) the justification for adequacy (risk tolerance and other factors), and (d) exceptions.

###### WHO (role responsible)
- **Cybersecurity / Vulnerability Management Lead**: owns the coverage model, the adequacy rationale, and the evidence pack.
- **Application Owner / Architecture Lead**: confirms the design-level mapping (component/module/subsystem/element identifiers) for the application.
- **Infrastructure / Cloud Security Engineer**: implements scanner scope and settings, and maintains scanner profile documentation.
- **Asset / Configuration Management Database (CMDB) Owner**: ensures the authoritative inventory information needed by the model is accurate and complete.

###### Acceptance criteria
- A documented **breadth/depth coverage model** exists and is approved by the Vulnerability Management Lead and Application Owner.
- Breadth targets are measurable (for example: % by criticality tier and/or system type) and include defined exceptions.
- Depth targets are defined using system design levels and are supported by inventory/SBOM/service mapping where relevant.
- Scanner configurations (profiles) clearly align to the model (scope rules and mapping rules are documented).
- For the most recent scan cycle, an evidence report shows the **actual breadth coverage** and **depth mapping performance**, with exceptions listed and justified.

###### Actions Required for Compliance

- [ ] Define a vulnerability scanning coverage model that links the organisation’s approved asset records to (1) how widely scanning should cover assets and (2) how deeply scanning should analyse each system at the design level.
- [ ] Set measurable coverage targets (for example, the percentage of components in each criticality tier and/or scanning all assets of defined system types) and record any exceptions.
- [ ] Set depth targets using system design terms (for example, component, module, subsystem, element) and define the required rules for mapping findings to the design.
- [ ] Choose the types of scanning tools and match them to the coverage model. Add and configure extra tools where a single tool cannot provide the required level of detail.
- [ ] Set up scanner profiles so the items included in the scan and the labels used for results match the coverage plan (what to include or exclude by tier and type, and how design elements are mapped).
- [ ] Document scanner configuration details that affect coverage, including how often scans run (cadence), what login credentials are used (authentication/credential scope), which network ports and protocols are allowed, any items excluded from scanning, and the rules used to match and map results.
- [ ] Produce evidence for each scan cycle that shows (1) how much of the required coverage was achieved and (2) how deep the mapping went, including why the coverage is considered sufficient and any exceptions.


---

#### RA-5.4 — Discoverable Information (Enhancement)

This requirement is about making sure that anything your systems accidentally expose to the public is quickly identified and dealt with. If information that should not be public is found through normal searching, or through what your systems unintentionally reveal, criminals could use it to target you more effectively, work out how your services operate, or find easier ways to gain access.

To meet this expectation, when the organisation confirms with evidence that specific information about a system can be found publicly, it must:
- notify the system owner and the Chief Information Security Officer,
- remove the information from public access or restrict it so it is no longer freely available, and
- update the system settings so the same or similar exposure is less likely to happen again.

The organisation must also record what was found, what actions were taken, who is responsible, and track the work until it is completed. It must keep clear evidence and any relevant test, risk, incident, and audit records, and ensure the right people and processes are used and linked to the system’s security documentation where applicable.

##### External discoverability monitoring with evidence-led remediation

- Category: Software
- Priority: High

###### WHAT
Put in place an automated process to identify what information about the system can be found publicly (without breaking or harming the system), verify the results using external proof, and then carry out the corrective actions defined by the organisation once public discoverability is confirmed.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **RA-5(4)** enhancement requires the organisation to **identify information about the system that is publicly discoverable** and then **take the corrective actions defined for `ra-05.04_odp`**. Publicly discoverable information includes what an attacker could obtain through normal collection methods (for example, exposed endpoints or content, indexing, and banners or metadata) without compromising the system. The corrective actions must include notifying the right people, removing or restricting the information, and updating configurations to reduce future exposure. This enhancement **excludes intentionally placed decoy or deception capabilities**.

###### HOW (specific steps/approach)
1. **Define an external discoverability scope and evidence format** for the application across production and any internet-facing parts (websites, application programming interfaces (APIs), admin interfaces, static content, documentation, public metadata, storage endpoints, and Transport Layer Security (TLS) and Domain Name System (DNS) fingerprints). Set what counts as “discoverable” and what evidence is required (for example, exact URLs, Hypertext Transfer Protocol (HTTP) status codes and headers, TLS certificate details, DNS records, and timestamps).
2. **Continuously monitor external exposure** using an enterprise-approved approach (for example, attack surface management tools and/or scheduled external checks) to identify potential exposures such as:
   - Publicly reachable admin or debug endpoints
   - Version or service banners and stack traces
   - Publicly indexed documentation or files
   - Misconfigured storage or object access
   - Leaked metadata in responses (headers, Hypertext Markup Language (HTML) comments, OpenAPI/Swagger details, and so on)
3. **Use a confirmation gate**: only treat a result as “discoverable” when it can be reproduced from an external viewpoint and you can capture evidence that can be audited.
4. **Exclude decoy or deception assets** by comparing results against an **approved deception registry or allowlist** (honeypots, honeynets, and deception networks). If a result matches an approved deception capability, do not trigger RA-5(4) corrective actions.
5. **Start the RA-5(4) corrective action process** when public discoverability is confirmed (as per `ra-05.04_odp`):
   - Notify the **system owner and the Chief Information Security Officer (CISO)**
   - **Remove or restrict** the publicly discoverable information (for example, disable an endpoint, remove public files, restrict access, revoke public links)
   - **Update configurations** to reduce exposure (for example, strengthen web or application settings, remove debug or version information leakage, fix storage and identity and access management (IAM) or public access settings)
   - **Record and track remediation to completion** with auditable evidence
6. **Re-check after fixes**: after changes, run the same external checks again and attach “before and after” evidence to the corrective action record to show the information is no longer publicly discoverable.

###### WHO (role responsible)
- **Application/System Owner**: responsible for remediation actions and configuration changes.
- **CISO (or delegated security leadership)**: receives notifications and ensures corrective actions are prioritised.
- **Security Operations / Application Security (AppSec) / External Exposure Monitoring team**: runs monitoring, performs confirmation checks, and manages evidence capture and workflow triggers.
- **Change Management / Infrastructure team**: implements configuration changes through approved change processes.

###### Acceptance criteria
- For each confirmed public discoverability finding (excluding deception), the process must:
  - Capture external evidence sufficient to reproduce the issue
  - Notify the system owner and the CISO
  - Create a corrective action record that is tracked to completion
  - Implement removal or restriction and configuration changes
  - Provide re-check evidence showing the information is no longer publicly discoverable
- Findings that match the approved deception registry must **not** trigger RA-5(4) corrective actions.

###### Actions Required for Compliance

- [ ] Set the scope for what the application can be found externally, including which internet-facing parts are included, which environments apply, and what proof or evidence is required.
- [ ] Set up monitoring of public-facing systems to find potential data disclosures, such as exposed endpoints, content being indexed, visible banners or metadata, storage that can be accessed, and identifying details from Transport Layer Security (TLS) and Domain Name System (DNS) lookups.
- [ ] Set up a confirmation step that requires repeatable external proof for every candidate finding.
- [ ] Create and keep an approved deception register (allowlist), and ensure that any decoy results that match it are excluded.
- [ ] Integrate the monitoring process with IT service management (ITSM) and ticketing so that the system owner and the chief information security officer (CISO) are notified, and so that corrective actions for RA-5(4) are opened.
- [ ] Create configuration “fix” runbooks to remove or restrict information that can be discovered, and to reduce the risk of future exposure.
- [ ] After fixes are completed, re-scan or re-test the issue. Attach before-and-after proof to the corrective action record until the action is closed.


---

#### RA-5.5 — Privileged Access (Enhancement)

This requirement ensures that only the right people can use extra-powerful access to the specific production and staging servers used for vulnerability scanning, including any secure classified enclaves and any systems that hold health information under the Health Insurance Portability and Accountability Act (HIPAA) or other personal information. Access must be used only for the approved testing work.  

Without this control, sensitive systems could be accessed for the wrong reasons, scanning could happen without the required checks, or access could be misused or go undetected—raising the risk of data exposure or service disruption.  

To meet this expectation, the organisation must:  
- Keep a documented list of the approved scan targets and the exact scanning activities that require elevated access.  
- Authorise privileged access only for those activities and only for named individuals or staff authorised through role-based access control (RBAC).  
- Require that scanning is carried out only after a successful login.  
- Use approved credentials.  
- Record and retain evidence of who accessed what and when.  
- Monitor usage, with decisions based on its risk policy, scanning procedures, the system security plan, and documented system design and configuration settings.

##### Purpose-scoped privileged access for authorised scan targets

- Category: Software
- Priority: Critical

###### WHAT
Set up privileged access authorisation so that elevated access is granted **only** for the organisation-approved **system components** and **vulnerability scanning activities** (RA-5(5): `{{ ra-05.05_odp.01 }}` and `{{ ra-05.05_odp.02 }}`), and only when the scanning is performed using authenticated access.

###### WHY (control requirement)
RA-5(5) enhancement requires: **“Implement privileged access authorisation to {{ system components }} for {{ vulnerability scanning activities }}.”** The guidance explains that allowing privileged access to selected components helps teams carry out more thorough scanning, while protecting sensitive scanning contexts (for example, classified/control unclassified information and personal data).

###### HOW (specific approach)
1. **Create a clear list of approved scan targets** covering production and staging servers that host scan targets, including classified enclaves and systems covered by HIPAA/personal data. Each list entry must include the environment (production/staging), asset identifiers (fully qualified domain name/internet protocol address), data sensitivity flags, and an explicit list of which scan types are allowed.
2. **Define privileged scanning activities as separate authorisation categories** that match the organisation-approved activities: authenticated vulnerability scanning, configuration compliance checks, and credentialed web application testing. Each category must be linked to the exact privileged capability needed (for example, a privileged access management role, a sudo group, an application test role, or a specific credentialed test account).
3. **Control privileged access using a privileged access management (PAM) / just-in-time (JIT) process** integrated with the organisation’s identity system:
   - Users and automated accounts must request elevation with **(a) the target component**, **(b) the scanning activity category**, and **(c) a reason and change reference**.
   - The PAM rules must check the request against the approved scan-target list and the allowed activity categories.
   - Elevated access must be **short-lived** and limited to the requested target(s) and category for the session.
4. **Require authenticated access and limit use to scanning**:
   - Only authenticated identities (human users and approved automated identities) can start privileged scanning sessions.
   - Privileged elevation must be denied if the requested activity category is not one of the approved scanning activities.
5. **Keep evidence and monitor activity**:
   - Record authorisation decisions and privileged session activity (who/what/when/which target(s)/category, approval result, session start/stop, and actions where available).
   - Send the logs to the security information and event management (SIEM) system so that monitoring and alerts can be triggered for policy violations (for example, privileged access to targets that are not approved, or activity outside approved categories).
6. **Make approval decisions based on risk**:
   - Set approval requirements and extra controls based on the system’s sensitivity flags (classified enclave versus HIPAA/personal data versus other confidential data) and the organisation’s scanning procedures and system security plan/configuration settings.

###### WHO
- **Security Architect / identity and access management (IAM) Architect**: designs the activity scope model, the PAM rules, and the risk-based approval logic.
- **Privileged Access Administrator (PAM owner)**: sets up the PAM/JIT configuration and session recording.
- **Vulnerability Management Lead**: maintains the approved scan-target list and the definitions of scanning activity categories.
- **SIEM/Monitoring Engineer**: ensures logs are collected and kept, and that alerting rules are in place.

###### Acceptance criteria
- Privileged elevation is granted **only** when the request matches an allow-listed **production/staging scan target** and an approved **scanning activity category**.
- Requests to elevate for non-approved targets or non-approved scanning activities are denied and produce audit evidence.
- Every privileged scanning session generates audit records showing the identity, target component, scanning activity category, authorisation/approval result, and session timing.
- Logs are sent to the SIEM system, and at least one alert exists for patterns that indicate policy violations (for example, mismatch between scope and target).

###### Actions Required for Compliance

- [ ] Create and keep an approved (allow-listed) list of the production and staging scan target servers, including whether they are in a classified enclave and whether they handle health information protected by the Health Insurance Portability and Accountability Act (HIPAA) or personal identifiable information (PII).
- [ ] Set the boundaries (scope) for privileged scanning activities for: authenticated vulnerability scanning, configuration compliance checks, and credentialed web application testing. Then link each scope to the specific privileged capability that is required.
- [ ] Set up privileged access management (PAM) with just-in-time (JIT) elevation so that any request to increase permissions must clearly state the target component and the activity scope, and is checked against the approved allow-list inventory and the defined scope rules.
- [ ] Only allow privileged access for a short time and for the specific session requested. If the requested scope and target are not authorised together, block any attempt to increase access rights.
- [ ] Integrate privileged access management (PAM) with the organisation’s identity provider to ensure that only verified users (people and approved automated accounts) can start privileged scanning sessions.
- [ ] Turn on logging for privileged scanning sessions and access permissions, and send those events to the security information and event management (SIEM) system for monitoring and record keeping.
- [ ] Set up security information and event management (SIEM) alerts for breaches of the privileged access policy, such as attempts to access systems that are not authorised or scanning activity outside approved scanning scopes.


---

#### RA-5.6 — Automated Trend Analyses (Enhancement)

This requirement is about using automated checks to track how security weaknesses change over time, not just finding them once. By comparing the results from several vulnerability scans, the organisation can identify worrying patterns, such as the same weak spots repeatedly returning, weaknesses steadily increasing, or the same areas being affected again and again. Without this, problems can be missed, repeated, or allowed to grow until they are exploited.

To meet this requirement, the organisation must set out in its risk and scanning procedures how it will carry out automated trend analysis by using scan comparison reports. It must ensure scans are compared across different dates and use automated tools to produce and record the trend findings. It must keep the original scan results and the trend outputs so they can be reviewed later, assign clear responsibilities for running the scans and analysing the results, and include this approach in system security planning and design records.

The organisation should also be able to provide the relevant documents and evidence, and show that the trend findings lead to clear, concrete follow-up actions.

##### Automated vulnerability scan trend analysis via scan comparison reports

- Category: Software
- Priority: High

###### WHAT
Set up an automated process that compares the results of multiple vulnerability scans over time and produces documented trend reports (including recurring-pattern findings) based on the scan comparison results.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **RA-5(6)** enhancement requires the organisation to **compare the results of multiple vulnerability scans** using the organisation-defined parameter **ra-05.06_odp (automated mechanisms)**. The goal is to spot trends and recurring patterns, rather than treating each scan as a one-off event.

###### HOW (specific approach)
1. **Define the scan-trend process** in the vulnerability scanning and risk procedures: set the scan frequency, the minimum number of scan runs needed to support trend comparison (for example, current versus previous and/or a rolling window), and the expected outputs (a trend report and a recurring-pattern summary).
2. **Automate the collection and comparison** of scan results within the vulnerability management and trend capability (for example, a platform that supports scan comparison and trend dashboards, or an automated process that creates comparison reports from scanner exports).
3. **Standardise the inputs** so the trends are meaningful: use consistent asset matching (the same asset identifiers and scope rules), consistent scan profiles where possible, and consistent mapping of vulnerability identifiers and severity across scan runs.
4. **Automatically produce and store trend outputs** each time a scan cycle runs: create a comparison report that clearly references multiple scan runs (at least two time points) and a trend output that highlights:
   - vulnerabilities that reappear across scans
   - vulnerabilities that increase in number and/or severity
   - assets that are repeatedly affected
   - notable changes caused by scope/profile/tool-version changes (flag these as exceptions)
5. **Set up an analyst review and follow-up loop**: send the trend outputs into the vulnerability management workflow (for example, ticket creation and prioritisation rules) so recurring patterns lead to real remediation work.
6. **Keep audit-ready evidence**: store the underlying scan results and the generated trend outputs with timestamps, tool and version details, and the comparison settings used.

###### WHO
- **Security Engineering / Vulnerability Management Lead**: defines the trend process, standardisation rules, and review/follow-up approach.
- **Security Operations Centre (SOC) / Security Operations (SecOps) Analyst (or Vulnerability Analyst)**: reviews the trend outputs and starts remediation actions.
- **Platform / Cloud / Infrastructure Engineer**: builds and maintains the automated collection/comparison process and the storage of evidence.

###### Acceptance criteria
- The organisation can show that **automated mechanisms** compare **multiple vulnerability scan results over time** and produce **trend analysis outputs** based on **scan comparison reports**.
- Trend outputs clearly compare results across **at least two scan runs** (different dates/time points) and identify **recurring patterns**.
- For each scan cycle, there is evidence of: stored scan results, generated comparison/trend reports, and documented comparison settings (scope/asset matching and identifier/severity standardisation).
- Recurring-pattern findings are connected to follow-up actions (for example, tickets/work orders) within the vulnerability remediation workflow.

###### Actions Required for Compliance

- [ ] Define the vulnerability scan trend analysis process (how often it runs, the time window each scan must cover, and the required results) in the vulnerability scanning and risk documentation.
- [ ] Set up automatic importing of vulnerability scan results into the comparison and trend feature, using scanner application programming interfaces (APIs) or export pipelines.
- [ ] Apply standard rules to match assets and to consistently link vulnerability identifiers and severity levels across all scan runs
- [ ] Enable automated generation of scan comparison and trend reports that use multiple scan dates and times.
- [ ] Store the original scan results and the generated trend outputs with dates and times, tool and version details, and the settings used for comparisons, so they can be used as audit evidence.
- [ ] Set up a process that sends recurring-pattern trend findings to the system that creates remediation tickets and prioritises them, and records what follow-up actions were taken.


---

#### RA-5.8 — Review Historic Audit Logs (Enhancement)

This requirement is about looking back to see whether a newly identified weakness in a specific system has been used by an attacker before. If the same weakness was exploited in the previous 365 days, it could indicate the organisation has already been breached, with data potentially taken or changed, and the effects may have lasted longer than anyone realised.  

To meet this expectation, the organisation must clearly identify the exact system in scope and review its historical audit records for the previous 365 days. It must use the documented details of the weakness to search for clear signs that it was exploited.  

The organisation must record whether any previous exploitation was found, and keep the key evidence and the steps used, so the review can be repeated and checked by someone else.

##### SIEM workflow to review prior exploitation for 365 days

- Category: Software
- Priority: High

###### WHAT
Set up a repeatable process that, for a defined **system** and a defined **time period** (as required by RA-5(8) parameters), checks that system’s **historical audit records** to see whether a **specific vulnerability** has been **previously exploited** within the defined window. Record the result with supporting information that can be checked later.

###### WHY (control requirement)
The RA-5(8) enhancement requires the organisation to **review historical audit records** to determine whether a vulnerability identified in the scoped **system** has been **previously exploited** within the scoped **time period** (for example, the previous 365 days). The review must be documented enough to support investigation after the fact and to allow the process to be repeated in the same way.

###### HOW (specific steps/approach)
1. **Create a “vulnerability-to-log” correlation template** that is evidence-led in the security monitoring and automation tool (security information and event management (SIEM) / security orchestration, automation and response (SOAR), or an equivalent logging/analytics platform). The template must take inputs for:
   - affected **system** (ra-05.08_odp.01)
   - **time period** (ra-05.08_odp.02; default previous 365 days)
   - vulnerability identifier/name (from the vulnerability record)
   - detection date (used to anchor the window if your process uses it)
2. **Define the main, trusted log sources for each system** (application audit records, operating system security logs, cloud audit trails, authentication/application programming interface (API) logs, and administrator activity logs). Keep a mapping of system → log sources → the required event types/fields.
3. **Run parameter-based searches/queries** that:
   - limit results to the **previous 365 days** (or the configured time period)
   - look for **signs of exploitation** based on the vulnerability details (for example, unusual authentication patterns, unauthorised API calls, command execution, web exploit attempts, privilege escalation, unusual file/process activity)
   - handle time zones and identity details consistently (service accounts, single sign-on (SSO) subject identifiers, device identifiers) so results can be reproduced.
4. **Produce an evidence pack** for each review run containing:
   - the query/template version (an unchangeable identifier)
   - the exact start and end dates/times used
   - the log sources that were checked
   - any matching events (timestamps, event identifiers/types, key fields)
   - the decision outcome: **“previous exploitation found”** or **“no previous exploitation found”**
   - reviewer notes explaining any assumptions or limitations (for example, missing log coverage)
5. **Record the outcome** in the case/vulnerability management system and link it to the vulnerability record and the evidence pack.
6. **Add a repeatability quality check**: require a second run (or re-run by an independent reviewer) using the same template version and time window for a sample of cases. Accept that outcomes must match, or that any differences are documented with objective reasons (for example, late log arrival, gaps in how long logs are kept).

###### WHO
- **Cybersecurity/security operations centre (SOC) analytics engineer**: builds the SIEM/SOAR correlation template, runs the queries, and automates the evidence pack.
- **SIEM/SOAR platform owner**: maintains the system → log-source mapping and manages query versioning.
- **Incident response / threat hunting analyst**: checks the signs of exploitation and reviews the evidence packs.
- **System owner / application owner (as needed)**: confirms that the log sources are complete and highlights any known gaps.

###### Acceptance criteria
- For a given vulnerability record, the workflow produces a review covering the configured **system** and the configured **time period** (default previous 365 days).
- The decision is recorded clearly as **previous exploitation found** or **no previous exploitation found**.
- Each decision includes an evidence pack with: template/query version, exact time window, log sources checked, and extracts of matching events (or a clear statement that there were no matches).
- A repeatability check can re-run the same template version and time window and reproduce the decision, or document objective reasons for any mismatch.

###### Actions Required for Compliance

- [ ] Define and keep an up-to-date, official list that links each affected system (ra-05.08_odp.01) to the log sources that contain the relevant audit events.
- [ ] Create a parameterised security information and event management (SIEM) / security orchestration, automation and response (SOAR) correlation template that takes the system and time period (ra-05.08_odp.02) as inputs, and sets the review window precisely.
- [ ] Add vulnerability-specific exploitation indicators to the template by defining the relevant event types and fields, and the query logic, based on the vulnerability record.
- [ ] Set up evidence pack generation that records: the template version used, the exact time window searched, the log sources that were checked, and the event extracts that matched.
- [ ] Record the review result (“previous exploitation found” versus “no previous exploitation found”) in the case and vulnerability management system, and include a link to the evidence pack.
- [ ] Run a repeatability check by re-running the same template version and time period for a sample of reviews, and record any objective differences found.


---

#### RA-5.10 — Correlate Scanning Information (Enhancement)

This requirement is about more than finding individual security weaknesses. It is about working out whether those weaknesses could be combined into a realistic, multi-step route that an attacker could use to get in and cause harm.  

Without this, your organisation might fix separate issues while missing the overall risk. For example, an attacker could use one weakness to reach another system or component, then use additional weaknesses to increase the damage—particularly during technology changes, such as moving from older network settings to newer ones where some parts may be missed.  

To meet this expectation, the organisation must take the results from its vulnerability scanning tools and analyse them together to identify any “attack paths” that involve more than one weakness and more than one step through connected systems or components, including during transitions such as moving from Internet Protocol version 4 (IPv4) to Internet Protocol version 6 (IPv6). It must document how this linking is done, name specific people to carry out the analysis and oversee the decisions, use the findings in risk assessment, and keep clear records and logs showing what was concluded and that the work was reviewed.

##### Correlate scan findings into multi-hop, multi-vulnerability attack paths

- Category: Software
- Priority: Critical

###### WHAT
Set up an “attack path” correlation capability that takes results from vulnerability scanning and matches them to which assets and services can reach each other. This will help identify and provide evidence of **multi-vulnerability** and **multi-hop** attack routes.

###### WHY (control requirement)
NIST SP 800-53 **RA-5(10)** requires the organisation to **correlate vulnerability scanning tool outputs** to determine whether **multi-vulnerability** and **multi-hop** attack routes exist. The guidance stresses using linked scan information to clarify “chained” hostile activity—especially during technology changes (for example, **IPv4 to IPv6**) where parts of the environment may be unintentionally left unmanaged.

###### HOW (specific steps/approach)
1. **Standardise scan results** into a single internal format for each finding, including: asset identifier, IP address/hostname, port/protocol, CVE/CWE, evidence, scan date/time window, and scanner confidence/severity.
2. **Create and maintain a reachability model** showing how an attacker could move between assets/services (for example, network paths, firewall/security-group rules, routing/DNS mappings, load balancer front-ends to back-ends, and relevant trust/identity relationships). Make sure the model is **dual-stack aware**, so IPv4 and IPv6 exposure are represented separately.
3. **Match findings to the reachability model** by linking each vulnerability finding to the relevant node(s) (asset/service) in the reachability map.
4. **Identify candidate attack paths**, keeping only those that meet both conditions:
   - **Multi-hop**: the route covers **2 or more hops** across different assets/services (not just multiple findings on one host).
   - **Multi-vulnerability**: the route requires **2 or more distinct exploitable weaknesses** across the chain (for example, different CVEs/CWEs that would need to be used to progress).
   Use transition-aware logic so newly exposed IPv6 services (or IPv6-only routes) are treated as important, first-class nodes.
5. **Create audit-ready correlation records** for every identified (or explicitly not identified) attack route, including:
   - Path ID, hop list (source to destination for each hop), vulnerability chain for each hop, and the scan window.
   - Evidence links back to the original scanner findings.
   - A clear decision on whether the chain meets the **multi-vulnerability** and **multi-hop** criteria.
6. **Feed the results into risk assessment processes** by exporting the correlation outcomes to the organisation’s risk register/ticketing system, referencing the correlation record IDs and scan windows.

###### WHO
- **Security Analytics Engineer / Vulnerability Management Lead**: builds the correlation logic, standardises the data, and calculates the paths.
- **Cybersecurity Risk Assessor**: reviews the correlation outputs and ensures they are interpreted correctly for risk assessment.

###### Acceptance criteria
- For a test dataset containing known chained weaknesses, the system produces at least one correlation record where the route meets **multi-hop (2+ hops)** and **multi-vulnerability (2+ distinct weaknesses)** criteria, with evidence links back to the original scan findings.
- For datasets that only contain single-hop or single-vulnerability conditions, the system records an explicit outcome: “no qualifying multi-hop/multi-vulnerability attack vector identified”, including the scan window.
- Correlation records are traceable and auditable: each route record includes the hop list, vulnerability chain, and references to the originating scan findings and scan window.
- IPv4/IPv6 transition scenarios are handled: IPv6-only exposure/route candidates are evaluated and recorded separately from IPv4.

###### Actions Required for Compliance

- [ ] Set a standard internal format for recording vulnerability scan results, including the affected asset or service, the port and protocol, the Common Vulnerabilities and Exposures (CVE) and Common Weakness Enumeration (CWE) references, the supporting evidence, and the time period when the scan was run.
- [ ] Create or update an asset or service reachability model that accounts for both Internet Protocol version 4 (IPv4) and Internet Protocol version 6 (IPv6) exposure and routes.
- [ ] Match each scan result to the relevant node(s) in the reachability graph, and save traceability links to the original scanner evidence.
- [ ] Set up attack-path correlation rules that only select attack paths with **at least 2 steps (hops)** and **at least 2 different exploitable weaknesses** across the full chain.
- [ ] Create audit-ready correlation records for every result, whether it qualifies or not. Each record must include the hop list, the vulnerability chain, and references to the scan time window.
- [ ] Share the correlation results with the organisation’s risk assessment process, including the correlation record reference IDs and links to the supporting evidence for review.


---

#### RA-5.11 — Public Disclosure Program (Enhancement)

This requirement is about making it easy and safe for people outside the organisation to report weaknesses they discover, so the organisation can fix them quickly. If there is no clear public way to report suspected problems, important warnings may be missed, delayed, or dealt with informally. This can give criminals more time to take advantage of the weakness and can lead to avoidable disruption, financial loss, or harm to customers.

The organisation is expected to provide a public, easy-to-find way to report suspected weaknesses in its systems and related parts (for example, a dedicated web page or contact method). It must also publish clear, plain-language instructions that explicitly welcome reports made in good faith and explain how the reporter can share the details with the organisation.

The organisation must not require reporters to keep the issue secret indefinitely, but it may ask for a specific, reasonable time period to allow the organisation to investigate and fix the problem properly.

##### Public vulnerability reporting channel with authorised disclosure window

- Category: Manual
- Priority: Critical

###### WHAT
Set up a publicly discoverable way to report security vulnerabilities (for example, a dedicated web page and/or email address). This should clearly allow good-faith security research and reporting to the organisation, and it should state a specific expectation for how quickly the organisation will respond and work to fix the issue.

###### WHY (control requirement)
RA-5(11) enhancement requires the organisation to “establish a public reporting channel for receiving reports of vulnerabilities in organizational systems and system components”. The channel must be publicly findable and include “clear language authorizing good-faith research and the disclosure of vulnerabilities”. It must not require reporters to agree to “an expectation of indefinite non-disclosure”. At the same time, the organisation may ask for “a specific time period to properly remediate the vulnerability”.

###### HOW (specific steps/approach)
1. **Publish a dedicated public page** (and/or a public email address) titled along the lines of “Report a Security Vulnerability / Responsible Disclosure”. Put it in a non-hidden, publicly accessible place (for example, the main website footer or security menu). Make sure it can be accessed without logging in.
2. **Use clear, plain-language permission statements** on the page that explicitly:
   - welcome good-faith reporting and disclosure to the organisation;
   - state what types of testing are allowed (for example, non-destructive testing and avoiding harm);
   - state what is not allowed (for example, destructive actions, taking data without permission, or denial-of-service attacks);
   - include safe handling guidance for sensitive information or evidence.
3. **Set a clear disclosure timing expectation** (for example: “we request a 60-day window to investigate and fix the issue; we may request an extension if the impact is complex”). Do not require indefinite non-disclosure.
4. **Put in place a process to receive and triage reports**, supported by the organisation’s ticketing or case-management system:
   - create a dedicated queue for vulnerability reports;
   - require a minimum set of information when submitting (affected system or product, impact, steps to reproduce, logs or screenshots, and reporter contact details);
   - define service levels for next steps (for example, acknowledge within X business days, technical review within Y days).
5. **Run the channel in practice and keep evidence**:
   - record the published web address and contact details in the organisation’s security governance documents;
   - keep records of submissions, triage outcomes, fix status, and closure dates so the process can be audited.
6. **Adapt for the organisation’s application environment** by routing each report to the correct technical owner (application security, engineering, or infrastructure). Use the organisation’s asset or product mapping from its inventory and configuration database, and separate handling by environment (live/production, test, and disaster recovery) so reports are managed consistently across all tiers.

###### WHO (role responsible)
- **Security Programme Manager / Chief Information Security Officer (CISO) Office**: owns the public disclosure wording and governance.
- **Application Security Lead**: owns the technical triage criteria, routing, and service levels.
- **Service Desk / Security Operations (Security Operations Centre (SOC) / Incident Response (IR) liaison)**: runs the intake queue, sends acknowledgements, and tracks progress.
- **Application Owner / Engineering Managers**: own the decisions to fix and close the issue.

###### Acceptance criteria
- A publicly accessible, no-login page or email address exists and can be found from the organisation’s public website navigation.
- The page includes clear, plain-language permission for good-faith research and reporting to the organisation.
- The page does **not** require indefinite non-disclosure; it includes a specific, reasonable time window for remediation (and an extension option if needed).
- Reports sent to the channel are received into a dedicated intake process with defined acknowledgement and triage service levels, and the status is tracked.
- Audit-ready evidence exists showing at least one complete report lifecycle (submission → triage → remediation and/or closure), and the retained published contact details.

###### Actions Required for Compliance

- [ ] Publish a public “Report a Security Vulnerability / Responsible Disclosure” page on the main website domain that anyone can access without logging in, and include a publicly available way to contact you.
- [ ] Draft and publish clear, plain-language authorisation terms for research and disclosure carried out in good faith, including a clear list of activities that are not authorised.
- [ ] Add a clear remediation disclosure timing statement (for example, a requested 60-day period), with an extension process for complex cases.
- [ ] Set up a dedicated vulnerability intake queue in the organisation’s ticketing system, with required submission fields and agreed triage service level agreements (SLAs).
- [ ] Set up routing to send requests to the correct application or infrastructure owner by using asset and product mapping, taking account of the environment (production, test, or disaster recovery).
- [ ] Set up how long to keep records for submission details, triage decisions, remediation progress, and closure dates, and record the published link and contact details in your security governance documentation.


---

### RA-6 — Technical Surveillance Countermeasures Survey (Control)

This requirement is about making sure your premises are regularly checked for hidden spying devices or other technical risks that could be used to break in or steal sensitive information. Without these checks, someone could secretly place equipment or take advantage of weaknesses around entry points and sensitive areas, such as perimeter access points, server rooms, and places where sensitive data is handled. This could lead to unauthorised access, disruption, or data theft.

The organisation must arrange for trained and qualified specialists to carry out a technical surveillance countermeasures survey at least once every quarter. This must cover all areas of the perimeter that can be accessed from outside, all server rooms, and all areas where sensitive data is processed. The checks must include visual, electronic, and physical inspections both outside and inside.

The organisation must also commission a targeted survey when there is suspected tampering, unexplained outages, unusual wireless or electromagnetic activity, or reports of suspicious devices. The organisation must record the results, keep evidence of the work completed, and use the findings to update risk assessments and plan any follow-up actions.

##### Quarterly TSCM survey service with indicator-triggered targeted resurvey

- Category: Manual
- Priority: Critical

###### WHAT
Commission and carry out a **technical surveillance countermeasures (TSCM) survey** at the organisation-defined schedule and locations. Use **qualified personnel** to perform **visual, electronic, and physical checks** of the surveyed site **both inside and outside**. Also commission a **targeted survey** when defined **events/indicators** occur.

###### WHY (control requirement)
NIST SP 800-53 **RA-6** requires the organisation to **“employ a technical surveillance countermeasures survey”** at the specified **locations** and **frequency**, using the required **scope** and **types of checks**. The guidance also expects the survey to detect technical surveillance devices/hazards, identify technical security weaknesses, and provide information for risk assessment.

###### HOW (specific steps/approach)
1. **Define the survey scope map** covering exactly the organisation-defined **locations**: **all externally accessible perimeter areas, server rooms, and sensitive data processing areas**.
2. **Contract qualified TSCM personnel** (or a TSCM service provider) and require in the statement of work that each quarterly survey includes **visual, electronic, and physical checks**, carried out **inside and outside** for every scoped location.
3. **Set the survey schedule** to **quarterly** (per `ra-06_odp.03`) and ensure the contract timetable aligns with the organisation’s quarter dates.
4. **Use indicator-triggered targeted surveys**: when any of the organisation-defined **events/indicators** occur—**suspected tampering, unexplained outages, unusual wireless/electromagnetic (EM) activity, or reports of suspicious devices** (`ra-06_odp.04`)—raise a time-limited request to the provider for a **targeted resurvey** of the affected location(s).
5. **Require evidence you can audit** from the provider for each survey: a location-by-location record of the checks carried out (visual/electronic/physical; inside/outside), the findings (including a high-level view of severity/likelihood of misuse), and recommended follow-up actions.
6. **Use results in risk decisions**: update the organisation’s risk assessment inputs (for example, the risk register and any relevant security planning documents) based on the survey results, and track remediation actions until completed.

###### WHO (roles responsible)
- **Information Security / Risk Owner**: owns RA-6 compliance, approves the scope map and how results feed into risk decisions.
- **Facilities/Physical Security Manager** (or equivalent): ensures the provider has access to perimeter areas and server rooms.
- **Security Operations / Security Operations Centre (SOC) Lead**: owns the process that triggers targeted surveys based on events/indicators.
- **Procurement / Contract Manager**: ensures the TSCM provider contract includes the required types of checks, inside/outside coverage, and evidence requirements.
- **Qualified TSCM Provider / Survey Personnel**: carry out the checks and produce the required evidence.

###### Acceptance criteria
- A **quarterly** TSCM survey has been completed for **all** defined locations (externally accessible perimeter areas, server rooms, sensitive data processing areas).
- Each quarterly survey includes **visual, electronic, and physical** checks and covers **inside and outside** for the scoped areas.
- For each occurrence of a defined indicator (tampering, unexplained outages, unusual wireless/EM activity, suspicious device reports), a **targeted resurvey** is commissioned for the affected location(s) within the organisation’s defined operational timeframe.
- Survey reports provide **audit-ready evidence** (dates, locations, types of checks, and findings) and the outcomes are **recorded as inputs to risk assessment**, with follow-up actions tracked to completion.

###### Actions Required for Compliance

- [ ] Create and keep up to date a survey scope map that covers all publicly accessible boundary areas, server rooms, and areas where sensitive data is processed.
- [ ] Procure or contract a suitably qualified technical surveillance countermeasures (TSCM) provider, with contractual requirements to carry out visual, electronic, and physical inspections both inside and outside the premises.
- [ ] Plan and carry out technical surveillance countermeasures (TSCM) surveys every quarter, following the frequency set by the organisation.
- [ ] Set up and run an indicator-based process that triggers requests for focused re-surveys when there are signs of possible tampering, unexplained outages, unusual wireless or electromagnetic (EM) activity, or reports of suspicious devices.
- [ ] Require location-by-location, auditable survey evidence, and keep the reports in a controlled repository with defined retention rules.
- [ ] Update the risk assessment information and track remediation actions until they are completed, based on the findings from each survey.


---

### RA-7 — Risk Response (Control)

This requirement ensures that every issue identified in reviews, checks, and inspections is given a clear, sensible decision and a follow-up action, rather than being ignored. Without it, weaknesses in how the organisation protects information and personal data could remain unresolved, allowing mistakes, misuse, or breaches to continue for longer than necessary and damaging trust with customers and regulators.

The organisation must review every finding from security assessments, privacy assessments, monitoring activities, and audits. It must then decide what to do next based on the level of risk it has agreed it can accept. For each finding, it must record the decision made and the reason, which may include fixing or strengthening controls immediately, creating a time-bound action plan when work cannot be completed right away, formally accepting the risk with justification, or choosing to share/transfer the risk or avoid it.

Named staff must be responsible for making these decisions and carrying out any required fixes. They must use the relevant reports and records as the basis for their decisions and track each item through to completion.

##### Risk-response workflow for all security/privacy/audit findings

- Category: Software
- Priority: Critical

###### WHAT
Set up an end-to-end, auditable process that makes sure every security and privacy assessment finding, monitoring finding, and audit finding is handled with a documented decision that matches the organisation’s acceptable level of risk (for example: mitigate, accept with justification, share/transfer, or avoid). If the required mitigation cannot be completed right away, the process must create and keep time-bound plan of action and milestones (POA&M) entries until the issue is fully closed.

###### WHY (control requirement)
Requirement RA-7 says the organisation must **respond to findings from security and privacy assessments, monitoring, and audits** in line with **organisational risk tolerance**. The guidance also requires that the risk response decision is made **before** creating a POA&M. If mitigation cannot be completed immediately, a **plan of action and milestones** entry must be created.

###### HOW (specific steps/approach)
1. **Create one “findings intake → risk response → POA&M → closure” workflow**, integrated with existing enterprise tools (for example: ticketing/IT service management (ITSM) plus the POA&M system, security information and event management (SIEM)/security orchestration, automation and response (SOAR), vulnerability/configuration compliance scanning tools, and audit management).
2. **Standardise each finding** into a consistent record that includes: the affected asset or service, data classification (including privacy sensitivity), severity/likelihood/impact (as the organisation defines them), links to evidence (assessment report section IDs, SIEM alert IDs, audit finding IDs), and the relevant organisational risk tolerance reference.
3. **Use risk-tolerance-based decision rules** through workflow steps and required information:
   - Response type: mitigate / accept (with justification) / share/transfer / avoid
   - Residual risk statement and a clear link to organisational risk tolerance
   - Reason/justification text (required for accept/share/avoid)
   - Named person responsible for the decision, and named person responsible for carrying out the mitigation
4. **Automate POA&M creation**: if the chosen response is **mitigate** and the mitigation cannot be completed immediately, automatically create a POA&M entry that includes:
   - Actions and dependencies
   - Milestones and target dates
   - How the work will be checked and confirmed (what evidence is needed to close)
   - A link back to the original finding record and the risk decision
5. **Control closure**: do not allow closure until the workflow has captured **closure evidence** (updated control evidence, scan/test results, current configuration status, or evidence from an audit re-test) and includes sign-off by the risk owner/approver.
6. **Make tracking and reporting routine**: provide dashboards and regular reports (for example, weekly/monthly) showing open findings, response types, how long POA&M items have been open, and overdue milestones—so nothing is left untracked.

###### WHO (role responsible)
- **Risk Owner / Information Security and Privacy Risk Committee representative**: accountable for approving the risk response decision in line with organisational risk tolerance.
- **Application Security/Privacy Lead (or equivalent)**: ensures findings are correctly standardised, evidence is complete, and POA&M actions are technically valid.
- **ITSM/POA&M System Owner / Workflow Administrator**: maintains workflow rules, required fields, and system integrations.
- **Control Implementers (engineering/infrastructure teams)**: carry out the mitigations and provide the evidence needed to close the finding.

###### Acceptance criteria
- For a sample of recent findings across **security assessments, privacy assessments, monitoring, and audits**, the workflow produces a **documented risk response decision** for each finding.
- For any finding where mitigation is not immediate, a **POA&M entry exists** with milestones and required verification evidence, and the finding remains open until closure evidence is provided.
- Each decision record includes an explicit **mapping to organisational risk tolerance** and mandatory **rationale** for accept/share/avoid.
- Closure is only possible after **evidence-based verification** and named sign-off by the risk owner/approver.
- Workflow dashboards show complete tracking (no findings without an assigned response and owner).

###### Actions Required for Compliance

- [ ] Combine security information and event management (SIEM), security orchestration, automation and response (SOAR), vulnerability and configuration compliance checks, privacy assessment results, and audit management into one single “findings intake” workflow.
- [ ] Define and implement a standard format for recording findings, including required links to supporting evidence and fields that reference the organisation’s agreed risk tolerance.
- [ ] Set up workflow decision rules so they must include: the response type, a mapping to the organisation’s risk tolerance, and a reason for the decision (required for accept, share, and avoid).
- [ ] Set up an automated process to create a plan of action and milestones (POA&M) for mitigations that are not immediate, including required milestones and the evidence needed to confirm they have been completed.
- [ ] Add closure gating so that findings can only be marked as closed after closure evidence is provided and the risk owner or approver has given a named sign-off.
- [ ] Set up reporting dashboards showing open findings and progress against the plan of action and milestones (POA&M) over time, and agree regular review schedules with named responsible owners.


---

### RA-8 — Privacy Impact Assessments (Control)

This requirement is about making sure the organisation considers privacy impacts before it builds or buys anything that will handle people’s personal information, and before it starts any new way of collecting that information using technology. Without this, the organisation could collect too much information, use it in the wrong way, share it without proper protections, keep it for too long, or allow people to be contacted or targeted online or in person when they should not be—causing real harm and leading to legal or reputational damage.

To meet this expectation, the organisation must complete a clear, documented privacy assessment and record the results before starting the relevant work. The assessment must cover what personal information will be handled, why it is needed, how it will be used and shared, the privacy risks, and the specific steps that will reduce those risks. The assessment must be detailed enough to show privacy was considered from the earliest planning stage and throughout the full life of the information. It must also be kept up to date whenever technology, working practices, or other factors change the privacy risks.

##### PIA gate in delivery lifecycle with living, versioned records

- Category: Software
- Priority: Critical

###### WHAT
Put a privacy impact assessment (PIA) “gate” into the way software and IT systems are delivered. Any project that will build or buy an IT system, or that will start collecting personal information (PII), must not move forward (including to go-live) unless there is a formally approved, documented PIA. The PIA must be treated as a “living document” and re-checked whenever changes affect privacy risks.

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **RA-8** requires the organisation to carry out privacy impact assessments **before** starting relevant systems, programmes, or activities. It also requires the PIA to be a **formal document** that explains how PII is handled, **identifies privacy risks**, and **sets out how those risks will be reduced**. Guidance also expects the PIA to be clear and specific from the earliest stages, to be **updated throughout the information life cycle**, and to remain a **living document** when technology or working practices change.

###### HOW (specific approach)
###### 1) Create standardised PIA intake and triggers
- Add a structured intake form into the portfolio or application lifecycle management (ALM) workflow (for example, Jira, Azure DevOps, or ServiceNow). This must capture, at minimum:
  - whether the initiative **will handle PII**
  - whether it is a **new collection of PII**
  - whether it **could enable contacting specific individuals** (for example, email, short message service (SMS), phone, or postal address, or online identifiers that support targeted outreach)
  - whether it uses **the same questions or reporting requirements** across **10 or more individuals** (with any applicable exclusions handled under the organisation’s internal policy)
  - data categories, purposes, data sources and destinations, sharing and third parties, retention and deletion approach, and cross-border considerations (if relevant)

###### 2) Produce a formal, version-controlled PIA document from the intake
- Use a controlled PIA template that requires explicit completion of:
  - applicable privacy requirements (law, policy, and contractual obligations identified by legal counsel and privacy specialists)
  - privacy risks (for example: collecting too much data, using data in the wrong way, sharing without authorisation, keeping data for too long, re-identifying people, and risks from targeting or contacting)
  - specific safeguards mapped to system design and day-to-day operating controls (not just general statements)
  - ownership and approval details (privacy senior lead or authorised privacy official, system owner, and relevant stakeholders)

###### 3) Enforce the “gate” in the delivery lifecycle
- Set up the workflow so that:
  - **no development or procurement ticket** can be approved to move beyond initiation without an **approved PIA reference**
  - **no release or go-live** can be approved without a current PIA version linked to the release materials (for example: architecture and design, data-flow diagrams, retention rules, and the integration list)

###### 4) Keep the PIA current by re-triggering reviews when changes happen
- Link to change management so that a PIA review is automatically re-started when any of the following changes occur:
  - new data fields or PII categories
  - new integrations or third-party sharing
  - changes to purposes, retention or deletion, or the access model
  - changes that increase the likelihood of contacting individuals or enable new targeting capabilities
- Require the updated PIA version to be approved before the change is released.

###### 5) Create evidence suitable for audit
- Store PIAs and supporting materials in a controlled repository with:
  - version history
  - approval records
  - links to the initiative and/or release
  - dates and times for the initial approval and subsequent updates

###### WHO
- **Senior privacy official / privacy team**: owns the PIA template, reviews and approves PIAs, and ensures the “living document” updates happen.
- **System owner / programme manager**: ensures the intake is completed accurately and that the PIA reference is linked to the delivery materials.
- **Application security / IT architects**: provide design details and implement the safeguards identified in the PIA.
- **Legal counsel (when needed)**: checks that the correct privacy requirements apply.
- **Change and release manager**: enforces the gate during release approvals.

###### Acceptance criteria
- For every initiative that will handle PII or start new PII collection, there is a **formally approved PIA document** completed before development, procurement, or collection begins.
- The PIA includes documented analysis of **privacy requirements**, **privacy risks**, and **specific safeguards** mapped to system design and operating controls.
- The PIA is **linked to release materials** and is re-approved when changes affect privacy risks.
- Audit evidence shows: version-controlled PIAs, approval details, and enforcement of the gate (no go-live without an approved PIA reference).

###### Actions Required for Compliance

- [ ] Define the personal information (PII) intake fields and the decision points in the delivery workflow, including: whether personal information is being processed, whether new personal information is being collected, whether there is a risk in contacting the person, and whether there are 10 or more identical questions.
- [ ] Create a controlled, versioned privacy impact assessment (PIA) template that requires privacy requirements, identified privacy risks, and mapped mitigations.
- [ ] Set up portfolio and application lifecycle management (ALM) controls, and release approval “gates”, to prevent development, procurement, and go-live activities unless there is an approved privacy impact assessment (PIA) reference.
- [ ] Set up change management so that privacy impact assessment (PIA) reviews are automatically restarted whenever data fields, integrations, purposes, how long data is kept and how it is deleted, or how people are contacted or targeted are changed.
- [ ] Set up a managed repository for privacy impact assessments (PIAs) that keeps a version history, records approval information, and includes links to the relevant initiative and release documents.
- [ ] Train system owners, system architects, and release managers on the PIA gate process and what evidence is required


---

### RA-9 — Criticality Analysis (Control)

This requirement is about deciding, before building or changing systems, which parts are truly critical to the organisation’s most important work—especially software services and connections that handle highly sensitive information or allow direct, unfiltered access. Without this step, teams may focus protection on the wrong areas, leaving the most damaging weaknesses undiscovered until it is too late—for example, when a key service fails, a dependency breaks, or an interface is exploited.

To meet this expectation, the organisation must analyse mission-critical systems, software services, and interfaces during architecture and design work, before any major design changes, and before upgrades are implemented and integrated. The analysis must break the system down into its missions, the functions that deliver them, and the hardware, software, and firmware that carry them out, including functions shared with other internal or external components.

The organisation must also consider legal and policy requirements, system needs, dependencies, and the impact of failure on organisational missions. It must treat any direct, unmediated access paths as critical. Finally, it must document the criticality decisions for each component or subcomponent and keep the analysis records available for review.

##### Criticality Gate in SDLC to analyse mission-critical components

- Category: Software
- Priority: Critical

###### WHAT
Add a mandatory **“criticality gate”** to the application’s architecture and change-management process. This gate must carry out and record a **criticality analysis** for the defined **systems, system components, or system services** at the defined **decision points in the system development life cycle**.

###### WHY (control requirement)
NIST SP 800-53 **RA-9** requires the organisation to **identify critical system components and functions** by carrying out a **criticality analysis** for **{{param, ra-09_odp.01}}** at **{{param, ra-09_odp.02}}**. The guidance also requires **functional decomposition** (missions → functions → links to the underlying hardware/software/firmware), taking account of **interfaces, dependencies, and shared functions**, and treating components that enable **unmediated access** as critical.

###### HOW (specific steps/approach)
1. **Define the RA-9 scope and decision points in the workflow**
   - Scope: mission-critical systems, software services, and interfaces that handle **Confidential/Secret data** and/or **unmediated access paths**.
   - Decision points: **architecture/design development**, **major design changes**, and **upgrades before implementation and integration**.
2. **Create a standard criticality analysis record (data model + template)**
   - For each candidate component/service/interface, record: mission(s), function(s), links to the items that implement them (for example, service name, API, database, message topic, firmware module), data sensitivity, a dependency list (including external/system-of-systems and outsourced information technology services), and the impact of failure on organisational missions.
   - Add a clear **“unmediated access path” indicator** (for example, direct network reachability to sensitive endpoints without any mediation, direct administrative interfaces, or bypass routes through shared services).
3. **Do functional decomposition and traceability during design/change**
   - Break the application down into mission-critical functions and link each function to the implementing components (for example, presentation/application/data/administration functions, APIs, identity integration points, handling of secrets, administrative consoles, remote access gateways, and relevant deployment services such as CI/CD).
   - Make sure traceability includes **shared functions/components** used both internally and externally.
4. **Build the gate into tools so designs/upgrades cannot proceed without proof**
   - Add a required checklist/approval step in the architecture review and change workflow (for example, ServiceNow/Jira plus the architecture repository) that prevents moving forward (promotion/merge/release) until the RA-9 criticality analysis record is completed for the scoped items.
   - Add completeness checks (for example, decomposition present, interface list present, dependency list present, final criticality decisions for each component/subcomponent present, and unmediated access assessment completed).
5. **Keep audit-ready evidence with version control and approvals**
   - Store the final criticality decisions and the supporting decomposition/traceability in a controlled repository linked to the design/change record, including the approver’s identity and timestamps.

###### WHO (role responsible)
- **Systems/Software Architect**: responsible for functional decomposition and traceability mapping.
- **Application Security/Architecture Governance**: checks that RA-9 records are complete and enforces the criticality gate.
- **Change Manager/Release Manager**: ensures the workflow gate is applied to major design changes and upgrades.

###### Acceptance criteria
- For each architecture/design development, major design change, and upgrade before implementation/integration, there is a completed RA-9 criticality analysis record covering the scoped **systems/components/services/interfaces**.
- The record includes functional decomposition (missions → functions → links to implementing components) and documents interface criticality and dependencies (including shared and external/system-of-systems dependencies).
- Any component/service/interface that enables **unmediated access paths** is clearly identified and marked as critical in the final decisions.
- Evidence is stored in a controlled, versioned repository and linked to the corresponding design/change record with recorded approvals.

###### Actions Required for Compliance

- [ ] Define the scope for {{ra-09_odp.01}} and the required decision points for {{ra-09_odp.02}} within the architecture and change workflow.
- [ ] Create a template and data structure for a criticality assessment that records each mission and function, how they can be traced, their interfaces and dependencies, the sensitivity of the data involved, and whether there is any direct (unmediated) access.
- [ ] Set up a “criticality gate” workflow that blocks architecture approval, code merges/releases, or promotion until the RA-9 document is completed for the items in scope.
- [ ] Train systems and software architects to break down each mission-critical function into smaller parts, and to link every mission-critical function to the specific components and interfaces that will implement it.
- [ ] Add automated checks to confirm that the decomposition, the lists of interfaces and dependencies, and the final decisions on criticality are included.
- [ ] Store and keep versions of the final criticality assessment evidence in a secure, controlled repository. Link it to each design or change record, and record who approved it (their identity) and the date and time of approval.


---

### RA-10 — Threat Hunting (Control)

This requirement is about actively looking for hidden signs that an attacker may already be inside your systems, and then acting quickly to stop them. If you do not carry out regular, structured checks, threats that get past everyday protections can remain unnoticed, leading to data theft, fraud, disruption of services, or long-term damage before anyone realises what is happening.

The organisation is expected to set up and maintain an ongoing threat-hunting capability. This should include clear responsibilities for the people involved and the right support from system and network administrators. The organisation should regularly search its systems for observable signs of compromise, identify threats that existing safeguards do not catch, and track what is happening over time. If threats are found, the organisation must take action to disrupt them.

This threat-hunting activity must be carried out every day. The approach must be documented, evidence must be kept in records, and the capability must be included in relevant security planning. It must also be aligned with the organisation’s risk priorities, supported by appropriate tools, and produce reports showing that it is operating as required.

##### Daily SIEM/SOAR threat hunting with auditable hunt evidence

- Category: Software
- Priority: Critical

###### WHAT
Set up a continuously running threat-hunting capability that carries out **daily** proactive searches across organisational systems for **indicators of compromise**. It must **detect, track, and disrupt** threats that get past existing protections. Make sure the hunting approach is **documented**, and keep **evidence** (for example, the versions of searches used, findings, analyst actions, and disruption results) so it can be reviewed for audit.

###### WHY (control requirement)
RA-10 requires an active threat-hunting capability that proactively searches organisational systems for advanced threats, with the organisation-defined **frequency** of **daily** activity (ra-10_odp: frequency). The guidance also requires using threat intelligence, tracking threats over time, and improving how quickly and accurately the organisation responds, including disrupting adversaries as early as possible.

###### HOW (specific steps/approach)
1. **Define the daily hunting scope and hypotheses**: create a documented set of hunting hypotheses linked to your risk priorities (for example, credential misuse, persistence, lateral movement, and data staging). Clearly state which IT environments are included (production/test/disaster recovery as applicable).
2. **Create “detection-as-code” hunt content**: implement version-controlled security information and event management (SIEM) searches and enrichment steps (for example, identity context, asset importance, and known-good baselines) so each hypothesis becomes a repeatable hunt.
3. **Run daily hunt jobs and produce a hunt report**: schedule the hunt content to run **daily** and produce a report for each run that includes: the time window, the search/content version, the matched entities, and the initial triage results.
4. **Triage, track, and disrupt with security automation guardrails**: use security orchestration, automation and response (SOAR) to enrich findings, open investigation cases, assign owners, and (where safe) carry out containment actions (for example, revoke sessions, disable accounts, and block indicators at proxy, domain name system (DNS), or firewall level). Require analyst approval for high-impact disruption actions.
5. **Maintain audit-ready evidence**: keep evidence that links each finding to (a) the exact search/content version, (b) the matched artefacts, (c) analyst decisions, and (d) any disruption actions taken and their outcomes.
6. **Operationalise governance and continuous improvement**: hold a recurring review (for example, weekly) to update the hunting hypotheses and hunt content based on results, false positives, and new threat intelligence.

###### WHO (role responsible)
- **Security Operations Centre (SOC) / Threat Hunting Lead**: owns the hunting hypotheses, daily execution, and reporting.
- **Security Information and Event Management (SIEM) / Security Orchestration, Automation and Response (SOAR) Engineer**: builds the detection-as-code hunt content, sets up scheduling, and ensures evidence is captured.
- **Incident Response / Security Analyst**: performs triage, tracking, and approves disruption actions.
- **System/Network Administrators**: provide support for containment/disruption steps that require infrastructure changes (for example, blocking using network controls).

###### Acceptance criteria
- Daily scheduled hunts run successfully, with evidence showing the run timestamp, time window, and content version.
- Hunt reports show proactive searches for indicators of compromise and list matched entities with triage outcomes.
- For confirmed threats, the organisation shows tracking over time and documented disruption actions with outcomes.
- Evidence is retained to support audit (search/content versions, findings, analyst decisions, and disruption records).
- Hunting documentation exists and is kept up to date, with version-controlled hunt content.

###### Actions Required for Compliance

- [ ] Record daily threat-hunting assumptions, what you will cover, and how you will measure success, aligned to your top risk priorities.
- [ ] Set up security information and event management (SIEM) “hunt” queries and the related data enrichment steps for each hypothesis, using version control so changes are tracked.
- [ ] Run the hunt content every day, and produce a separate report for each run showing the time window used and the version of the content.
- [ ] Set up security orchestration, automation and response (SOAR) workflows to sort alerts, add extra information, start investigation cases, and assign responsible owners so progress can be tracked.
- [ ] Define and put in place disruption plans (“playbooks”), with analyst approval checkpoints before taking any high-impact actions.
- [ ] Store audit-ready evidence that links each finding to the specific query or content version, the analyst’s decisions, and the resulting disruption outcomes.
- [ ] Run a weekly review to update threat-hunting content based on results and new threat intelligence.


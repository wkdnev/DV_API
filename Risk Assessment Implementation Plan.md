### RA-1 — Policy and Procedures (Control)

This requirement is about making sure the organisation has a clear, written plan for how it will assess risks, who is responsible, and how the plan will be kept up to date. Without this, the organisation could miss important threats, make inconsistent decisions across different teams, or fail to respond when laws, rules, or real incidents change—leaving it exposed to avoidable harm and compliance problems.

The organisation must create and document a risk assessment policy and practical procedures for carrying it out. These documents must cover the purpose, what they apply to, roles and responsibilities, management support, how different parts of the organisation will work together, and how legal and regulatory expectations are met.

The Chief Information Security Officer must oversee creating, documenting, and sharing these documents. The policy must be reviewed at least every year, and also after any risk assessment or audit findings, confirmed security incidents or breaches, or significant changes to relevant requirements. The procedures must follow the same approach, with updates after any material findings or confirmed incidents.

##### CISO-owned risk assessment policy and role-based procedures

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Draft organisation risk assessment policy (purpose, scope across org/mission/business process/system levels, roles & responsibilities, security/privacy coordination, compliance alignment) | Compliance Manager | Enterprise | 24h | — |
| Draft role-based risk assessment procedures (initiation, execution steps, documentation/records, review & approval workflow, escalation paths, tailoring guidance) | Security Engineer | Enterprise | 28h | — |
| Define dissemination lists and communication plan (policy and procedures recipients; acknowledgement requirements; training/briefing approach) | Project Manager | Enterprise | 10h | — |
| Establish update triggers and review cadence governance (annual review; event-driven updates; RACI for triggers; evidence requirements for change rationale) | Compliance Manager | Enterprise | 12h | — |
| Implement document control and evidence in document management system (versioning, approval records, distribution/acknowledgement logs; linkage from system security/privacy plans) | Operations Lead | Enterprise | 16h | £2,500 |
| Run policy/procedure review workshops and incorporate stakeholder feedback (security programme lead, privacy programme lead, risk management team, ISSOs/system owners) | Cyber Security Lead | Enterprise | 18h | — |
| Final approval, publication, and rollout (sign-off, publish to repository, confirm dissemination logs, and baseline audit-ready evidence pack) | Compliance Manager | Enterprise | 14h | — |

**Total Estimated Effort:** 122h  
**Total Estimated Cost:** £2,500

###### Actions Required for Compliance

- [ ] Draft and obtain formal approval for an organisation-wide risk assessment policy, which is owned by the Chief Information Security Officer (CISO).
- [ ] Set up and publish the distribution lists for the policy and for the procedures, and share them with the specified roles.
- [ ] Create role-based risk assessment procedures that set out the steps to follow and the required outputs and records.
- [ ] Set and document a review and update schedule: review at least once a year, and update both the policy and the procedures after the defined events.
- [ ] Put in place document control, including version tracking, recorded approvals, and proof that documents were shared and acknowledged.
- [ ] Publish the policy and procedures, and reference them in the system security and privacy plans where system-specific changes are needed.


---

### RA-2 — Security Categorization (Control)

This requirement is about making sure your organisation clearly decides how sensitive each system and the information it handles really is. The decision should be based on what harm could happen if that information were exposed, changed, or became unavailable. Without this, you might treat highly sensitive information the same as low-risk material, which could leave the business, its assets, and its people exposed to avoidable damage, legal problems, or disruption to operations.

To meet this expectation, the organisation must assign a security category to each system and to all relevant information it processes, stores, and transmits. It must also record both the decision and the plain-language reasons for it in the system’s security plan.

The organisation must ensure that the authorised decision-maker, or someone officially appointed to act for them, reviews the categorisation and formally approves it based on the documented results. The organisation must also keep the categorisation accurate as systems and the way information is handled change.

##### RA-2 security categorisation workflow with documented approval

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define and publish the standard CIA impact-to-category mapping (including privacy impact considerations) with clear decision rules and examples | Compliance Manager | Enterprise | 24h | — |
| Create/refresh categorisation templates for (a) system-level and (b) information-type/data-set-level assessments, including plain-language rationale and evidence-source fields | Compliance Manager | Enterprise | 16h | — |
| Establish the evidence-linking approach (where evidence is stored, naming conventions, and how BIAs/PIAs/legal/contractual inputs are referenced) | Data Protection Officer | Enterprise | 12h | — |
| Perform security categorisation for the target application system and each relevant information type/data set; produce draft categorisation outputs with CIA impact analysis and privacy considerations | System Design Authority | Business Unit | 40h | — |
| Populate the application system security plan with the approved categories, written rationale, and pointers to supporting evidence for both system and information types/data sets | Security Engineer | Business Unit | 24h | — |
| Implement the approval workflow and audit trail: route categorisation package to the authorised official/designated representative; capture approval decision, date, and approver identity | Project Manager | Enterprise | 20h | — |
| Define and integrate re-categorisation triggers into change/release governance (e.g., new data types, new sharing, major architecture/regulatory/privacy scope changes) and document the operational procedure | Operations Lead | Enterprise | 16h | — |

| Total Estimated Effort | Total Estimated Cost |
|---:|---:|
| 152h | £0 |

###### Actions Required for Compliance

- [ ] Define and publish a standard mapping between the impact level of an incident and the corresponding security category, and use it for all application systems.
- [ ] Carry out complete security classification for the application system and every relevant type of information/data set, using confidentiality, integrity and availability (CIA) impact analysis (including privacy impacts where applicable).
- [ ] Record the results of the categorisation and provide a plain-language explanation for why, including the evidence sources, in the application’s system security plan.
- [ ] Get formal approval for the categorisation decision from the authorised official (or their nominated representative) and keep a record of the approval audit evidence.
- [ ] Link the evidence used for link categorisation to the system security plan, including where any privacy impact, business impact, and legal evidence is stored.
- [ ] Set up governance “change triggers” so that any significant changes to data types, data movement, data sharing, or system architecture start a review to re-categorise the data.


---

#### RA-2.1 — Impact-level Prioritization (Enhancement)

This requirement is about ranking your business systems by how much impact they would have if something went wrong, so you know where security work should be focused first. If you only group systems as broadly low, medium, or high impact, you may spend time and money in the wrong places—either leaving the most damaging weaknesses insufficiently protected, or spending more than necessary where the risk is lower.

To meet this expectation, the organisation must review and prioritise all in-scope systems based on their impact level. It should start with the impact category that is already assigned to each system, and then break any low/medium/high categories into smaller sub-groups when more detail is needed to make better, risk-based decisions.

The outcome must be recorded in the organisation’s security categorisation records and reflected in system planning documents. Named responsibility must be assigned to the people who carry out the work. The prioritisation must then be used to decide where to invest in security and to guide how security measures should be adjusted.

##### Impact-level prioritisation with sub-category matrix for each system

- Category: Manual
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Draft standard procedure for impact-level prioritisation and sub-category criteria (drivers, decision logic, “no split” rules, evidence requirements, governance escalation) | Compliance Manager | Enterprise | 24h | — |
| Create and approve the “Impact Partitioning Matrix” mapping low/moderate/high to sub-categories, including explicit derivation rules and boundary conditions | GRC Lead | Enterprise | 16h | — |
| Update security categorisation record templates (and any associated forms) to capture: initial high-water mark category, selected sub-category, evidence pointers, and decision rationale | Data Protection Officer | Enterprise | 12h | — |
| Perform system-by-system impact partitioning for all in-scope systems in the authoritative inventory (including prod/test/DR where treated separately), recording outputs and audit evidence pointers | System Design Authority | Enterprise | 80h | — |
| Update each system security plan (and privacy plan where applicable) to reference the assigned sub-category and link to the resulting control baseline/tailoring and security investment focus | Security Engineer | Enterprise | 56h | — |
| Define review cadence and change-trigger rules; implement a lightweight workflow/checklist to ensure annual review and trigger-based re-assessment are completed and evidenced | Project Manager | Enterprise | 20h | — |
| Run governance validation: committee review of exceptions/ambiguous cases and sign-off of consistency across systems; produce an audit-ready summary pack | Compliance Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 224h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Publish an “Impact Partitioning Matrix” procedure that sets sub-category criteria based on the existing low, moderate, and high categorisation.
- [ ] Use the matrix for every in-scope system, and record the initial category, the selected sub-category (or note “no split”), the evidence references, and the reason for your choice.
- [ ] Update each system security plan and privacy plan to point to the relevant sub-category, and to specify the resulting security control baseline (and any tailoring) and where investment should be focused.
- [ ] Set up and carry out a regular review schedule, and define clear triggers for when re-partitioning is needed (for example, when new regulated data is added, new external data exchanges are introduced, major integrations are made, or changes are made to the privilege model).
- [ ] Carry out governance checks to confirm the same rules are applied consistently across information technology (IT) and any relevant operational technology (OT) or other critical environments.


---

### RA-3 — Risk Assessment (Control)

This expectation is about making sure the organisation regularly checks what could realistically go wrong with a system and the personal information it handles, and then uses that understanding to make sensible decisions. Without this, weaknesses might be missed, the level of harm might be underestimated, and the organisation could end up investing in the wrong fixes or leaving serious risks unaddressed, including risks to individuals such as identity theft or financial loss.

The organisation must carry out an ongoing risk assessment that:
- identifies threats and weaknesses;
- estimates how likely different kinds of harm are and how severe they would be; and
- separately considers the impact on individuals where personal data is processed.

It must then combine these findings with risk decisions made from both an organisational perspective and a business-process perspective. The organisation must record everything in a Risk Assessment Report, review it every 90 days, share the results with the Authorising Official, the Chief Information Security Officer, the system owner, and the mission or business process owners, and update the assessment at least annually and whenever significant changes occur to the system or its operating environment.

##### RA-3 living risk assessment with privacy and governance workflow

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define RA-3 scope, boundaries and “related information” mapping across environments (prod/test/DR), including external parties/contractors and dependency inventory | System Design Authority | Enterprise | 16h | — |
| Create and populate the structured threat/vulnerability register with evidence links (from vuln management outputs, config baseline findings, pen test results, threat intel/observed detections) mapped to affected assets/data flows | Security Engineer | Enterprise | 40h | — |
| Define and apply approved likelihood/impact rating scales and rationales for each threat scenario (CIA + magnitude of harm to organisational operations/assets and individuals) | Cyber Security Lead | Enterprise | 24h | — |
| Perform privacy risk assessment: map personal data categories to threat scenarios and document privacy-specific adverse effects on individuals with likelihood/impact | Data Protection Officer | Enterprise | 24h | — |
| Integrate governance risk decisions into the RA-3 workflow: capture risk acceptance/treatment/prioritisation from mission/business process owners and show how decisions influence system-level risk posture | Compliance Manager | Enterprise | 20h | — |
| Produce the auditable RA-3 Risk Assessment Report template and complete RA-3 report for the application (threats, vulnerabilities, likelihood, impact, privacy impacts, risk decisions, evidence links, and change triggers) | Project Manager | Enterprise | 32h | — |
| Establish governance checkpoints and cadence: run initial 90-day review pack, define annual update process, and implement change-significant triggers with documented outcomes and dissemination to Authorising Official, CISO, system owner and business process owners | Operations Lead | Enterprise | 24h | — |

Total Estimated Effort: **200 Hours**  
Total Estimated Cost: **£0**

###### Actions Required for Compliance

- [ ] Define the scope for RA-3 and clearly document the system boundaries and any “related information” dependencies, including identity, logging and security information and event management (SIEM), backup and restore, integrations, and third parties.
- [ ] Maintain an auditable record of known threats and vulnerabilities for the application and its external-party components, including evidence links for each item.
- [ ] For each threat or vulnerability scenario, calculate and record the likelihood and impact ratings, including how much harm it could cause to organisational objectives and to individuals.
- [ ] Complete the privacy risk assessment by linking each category of personal data to possible threat scenarios, and record any harmful effects on individuals, including how likely they are and how severe they would be.
- [ ] Record the risk decisions (accept, treat, or mitigate) and the reasons for each decision in the RA-3 report, using risk information from the mission and business-process teams.
- [ ] Arrange and carry out formal RA-3 reviews every 90 days with the Authorising Official, Chief Information Security Officer (CISO), the system owner, and the owners of the mission or business processes; keep the evidence from each review.
- [ ] Review and update RA-3 every year. If there are significant changes, make an update outside the normal schedule. Record what triggered the change and what was changed as a result.


---

#### RA-3.1 — Supply Chain Risk Assessment (Enhancement)

This requirement is about making sure the organisation understands the risks that can come from suppliers and other third parties before and during the life of the on-premises systems that run both information technology (IT) and operational technology (OT). If these supply chain risks are ignored, problems such as delayed deliveries, faulty or counterfeit parts, theft, or even software that is deliberately harmful could be introduced. This could lead to loss of service, disruption to operations, and harm to the organisation’s reputation and people.

To meet this expectation, the organisation must first identify and cover all in-scope systems, components, and services used for on-premises mixed IT/OT operations. It must then carry out a supply chain risk assessment for each one and record the results so they can be reviewed later. The assessment must be updated at least every 12 months, and within 30 days whenever there is a significant change to suppliers, components, deliveries, the system, its operating environment, or other conditions that could affect the risk.

The organisation must define what counts as a significant change, keep clear records of reviews and updates, and share the assessment outcomes with the relevant people responsible for acting on them.

##### Inventory-linked supply chain risk register with 30-day trigger updates

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define scope model and authoritative inventory data model for in-scope IT/OT systems, components, and system services (including required identifiers, supplier linkage, environment segregation, and evidence pointers) | System Design Authority | Enterprise | 24h | — |
| Develop standard supply chain risk assessment template aligned to supply chain event categories (disruption, defective components, counterfeits, theft, malicious development, improper delivery, malicious code) with required fields, severity/risk rating logic, and mitigation decision options | Compliance Manager | Enterprise | 32h | — |
| Configure the inventory-linked risk register workflow (record creation, evidence linkage, reviewer/approver roles, audit trail, and dissemination to procurement/engineering/security governance) with annual cadence enforcement | Security Engineer | Enterprise | 40h | — |
| Implement “significant change” trigger rules and 30-day reassessment SLA (e.g., new supplier/contractor, major version/build change, High/Critical vendor advisory, delivery/maintenance method change, system/environment change affecting supply chain risk) | Platform Engineer | Enterprise | 32h | — |
| Automate evidence capture and mapping to inventory items (SBOM/artefact metadata ingestion, vendor advisories, end-of-support dates, provenance/signature attestations where available) and ensure evidence is retained in the register with versioned history | DevOps Lead | Enterprise | 56h | £18,000 |
| Build reporting and audit pack outputs (timeliness dashboards, annual review completion, trigger-to-approval cycle time, evidence completeness scoring, and exportable audit evidence) | Compliance Manager | Enterprise | 24h | — |
| Pilot on a representative set of in-scope systems/components, validate trigger accuracy and 30-day completion, then refine templates/workflows and roll out to remaining scope | Project Manager | Business Unit | 40h | — |

**Total Estimated Effort:** 248h  
**Total Estimated Cost:** £18,000

###### Actions Required for Compliance

- [ ] Create and get approval for an official, complete list (inventory) of all in-scope on-premises mixed information technology (IT) and operational technology (OT) systems, components, and system services.
- [ ] Set up a supply chain risk register using a standard template for assessing each item, covering all required supply chain event categories.
- [ ] Define and document the “significant change” triggers that require reassessment, and link each trigger to the relevant inventory item.
- [ ] Set up automated collection of proof (for example, software bill of materials (SBOM) and file details, supplier security updates, end-of-support dates, and signed statements) and attach the relevant proof to each item in the inventory.
- [ ] Set service-level agreements (SLAs) for the workflow so that reassessments happen at least once every year and within 30 days of the trigger being activated, with approval from the reviewer.
- [ ] Set clear rules for sharing the results of risk assessments and the required mitigation actions with the procurement, engineering, and security governance teams.
- [ ] Check that the organisation is ready for audit by producing sample proof that shows: the review dates, where the evidence came from, the risk decisions made, and the latest updates to mitigation actions.


---

#### RA-3.2 — Use of All-source Intelligence (Enhancement)

This requirement is about using a wide range of reliable information to identify and understand risks before they cause harm. Without it, an organisation may miss important weaknesses, whether they come from how something is designed and made, how products are delivered, the people involved, or the wider environment—and whether those weaknesses are intentional or accidental.

To meet this expectation, the organisation must build this approach into its risk assessment and planning. It must have clear, written procedures for how it gathers, selects, and uses relevant information from multiple sources. These sources must include publicly available information and at least one other type of evidence, such as internal test results, supplier information, observations, or incident history.

The organisation must assign responsibility to named people, carry out risk analysis using this evidence, and keep documented records of the findings, the reviews, and any updates. These records should be supported by risk intelligence reports.

Where suppliers are involved, the organisation must also use this evidence-based approach to manage supplier risks, including key sub-suppliers where needed, and record how decisions and actions were informed.

##### Evidence-graph workflow linking all-source intelligence to risk

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define intelligence evidence schema & taxonomy (mandatory fields: source type incl. open/public + ≥1 non-open, lifecycle area, vulnerability class, intentional/unintentional tag) and publish governance guidance for risk workflow usage | Compliance Manager | Enterprise | 24h | — |
| Design evidence-graph data model and mapping to risk records (including deduplication keys and provenance metadata: origin, date, confidence/validity notes) | System Design Authority | Enterprise | 32h | — |
| Implement controlled internal evidence repository integration (GRC-integrated data store) with ingestion, normalisation, deduplication, and provenance capture | Platform Engineer | Enterprise | 56h | £18,000 |
| Configure risk assessment workflow enforcement (mandatory evidence attachments: ≥1 open/public + ≥1 non-open; validation rules for lifecycle area, vulnerability class, and intentional/unintentional tagging; capture how evidence informs likelihood/impact and treatment) | DevOps Lead | Enterprise | 40h | £6,000 |
| Implement traceability & audit artefacts (persist evidence links across risk reviews/updates; store rationale for likelihood/impact adjustments, mitigation selection/changes, review trigger, and evidence usage date) | Security Engineer | Enterprise | 32h | — |
| Extend evidence-graph requirements to supplier risk assessments (including key sub-suppliers where used): workflow configuration, evidence mapping to supplier lifecycle risks, and rationale retention | Service Delivery Manager | Enterprise | 24h | — |
| Execute pilot, test evidence-link persistence across review cycles, and remediate gaps to meet acceptance criteria (sample risk assessments + supplier assessments) | Project Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 232h  
**Total Estimated Cost:** £24,000

###### Actions Required for Compliance

- [ ] Create a standard “intelligence evidence” template for risk assessments. It should record: the type of information source, the stage of the lifecycle it relates to, whether the activity was intentional or unintentional, and the category of vulnerability.
- [ ] Set up a managed intelligence repository that records where each item came from (provenance metadata) and removes duplicates using the component, version, Common Vulnerabilities and Exposures (CVE) identifier, and asset identifier.
- [ ] Set up the governance, risk and compliance (GRC) workflow so that each risk record must include at least one open or public evidence item and at least one non-open evidence item based on technical or observational information.
- [ ] Add required traceability fields that record how the evidence was used to decide the likelihood and impact, how it informed the choice of mitigations, and what review triggers apply.
- [ ] Where appropriate, include supplier risk assessments in the same evidence-tracking workflow for key sub-suppliers.
- [ ] Run a trial using representative application and supplier risks, and confirm that the completed risk records have audit-ready evidence that can be traced back to their source.


---

#### RA-3.3 — Dynamic Threat Awareness (Enhancement)

This requirement is about keeping a current, live view of the cyber attacks that are most likely happening now, rather than relying on assumptions that may no longer be accurate. Without this ongoing awareness, the organisation could miss early warning signs, fail to recognise how quickly attackers are using newly found weaknesses, and keep everyday security rules unchanged even as the threat level increases—making successful intrusions more likely.

To meet this expectation, the organisation must regularly assess the current threat environment on an ongoing basis using three sources: up-to-date threat information from external feeds, information about newly discovered or currently being used weaknesses, and active review of warning signs that an attack may already be in progress. The findings must be provided to information security operations so procedures are updated when the threat level changes, including adjusting access and login expectations where appropriate.

This approach must be documented in planning, with responsibilities assigned, outcomes recorded, reviewed, and updated over time, and with evidence kept.

##### Automated threat environment fusion feeding security ops

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define threat levels and operational mappings (Low/Guarded/Elevated/Critical) including concrete SOC actions (step-up auth, MFA assurance, privileged access workflow strictness, monitoring escalation) and produce an approval pack for governance/change | Compliance Manager | Enterprise | 24h | — |
| Design the threat environment data model and evidence requirements (per assessment output: required inputs used, confidence/rationale, scope/coverage, timestamps) and publish correlation logic specification | System Design Authority | Enterprise | 32h | — |
| Implement ingestion and normalisation for required means: (a) threat intel feeds (STIX/TAXII/vendor APIs) to intel enrichment layer, (b) vulnerability intelligence (CVE/CPE, actively exploited focus, exploitability scoring), (c) IoC monitoring via SIEM/EDR/XDR log sources; include field mapping and data quality checks | SIEM/SOAR Engineer | Enterprise | 80h | £12,000 |
| Build continuous correlation and “threat environment” scoring logic with confidence weighting and scope segmentation (e.g., business unit/asset group/technology stack); include unit tests and validation against historical scenarios | Security Engineer | Enterprise | 72h | — |
| Implement auditable threat environment bulletin generation (scheduled cadence + immediate trigger on significant changes) and create workflow tickets with full evidence payload (inputs used, rationale/confidence, computed threat level, recommended actions) | SOC Lead | Enterprise | 40h | — |
| Integrate bulletin outputs into SOAR/workflow to update security operations procedures via controlled actions; implement at least one demonstrable escalation that changes privilege/authentication thresholds (e.g., step-up MFA for defined populations, tighter privileged approval) | DevOps Lead | Enterprise | 56h | £6,000 |
| Evidence retention, audit trail hardening, and periodic review process (retention policy alignment, immutable logging where required, correlation tuning review cadence, and runbook updates) | Data Protection Officer | Enterprise | 32h | — |

**Total Estimated Effort:** 336h  
**Total Estimated Cost:** £18,000

###### Actions Required for Compliance

- [ ] Set clear threat levels and approve how each threat level should change day-to-day actions, including any changes to privilege and authentication requirements.
- [ ] Set up the collection and standardisation of threat intelligence feeds, vulnerability intelligence, and the required log sources so that active indicators of compromise (IoC) monitoring can run.
- [ ] Set up continuous monitoring that links threat intelligence (TI), vulnerability information (VI), and indicators of compromise (IoC) to produce a threat view that is weighted by confidence.
- [ ] Automatically create a dated, auditable “threat environment” bulletin or ticket that records the information used and the resulting threat level.
- [ ] Link bulletin updates to security automation and workflow tools so that, when the threat level changes, they trigger controlled updates to security procedures.
- [ ] Test and confirm that at least one escalation scenario changes the privilege and authentication limits, and that the system keeps the evidence from the test.


---

#### RA-3.4 — Predictive Cyber Analytics (Enhancement)

This requirement is about using smart, automated analysis to spot likely security problems before they fully develop. It means continuously monitoring information from your main information technology services, your operational technology network areas, and your on-site security monitoring tools. Without this, your security team can be overwhelmed by too much information and may only notice attacks after damage has been done, or miss early warning signs that unusual behaviour is building.

To meet this expectation, the organisation must:
- define where these predictive analytics apply,
- ensure the right data keeps flowing into the analysis, and
- use learning-based analytics to identify and connect suspicious patterns, detect unusual behaviour, and estimate future risk levels.

This should also include structured analysis that links findings to known attacker behaviours. Any automated actions must adjust based on the surrounding context, but people must review the system’s conclusions before any high-impact steps are taken. This must be supported by clear records, regular reviews, and updates whenever the analytics or its inputs change, so risk reports can be shared with the right decision-makers.

##### ML predictive risk scoring with human-gated SOAR workflows

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define predictive analytics scope, risk outputs, and gating thresholds (risk score bands, high-impact action list, evidence requirements) | Compliance Manager | Enterprise | 24h | — |
| Design and implement unified telemetry ingestion + normalisation for Enterprise IT services, OT segments, and on-prem sensors (data contracts, schema mapping, retention alignment) | Data Protection Officer | Enterprise | 56h | £25,000 |
| Build ML-assisted behavioural anomaly detection and predictive risk scoring (baseline modelling, feature engineering, scoring logic, confidence calibration) | Security Analytics Engineer | Department | 120h | £60,000 |
| Implement ML-assisted threat discovery/correlation and MITRE ATT&CK mapping (technique/tactic candidates, ATT&CK ID storage, explainability fields, evidence linkage) | Architect | Department | 96h | £15,000 |
| Develop adaptive SOAR-style workflows with human-in-the-loop approval (context enrichment, low-impact auto-actions, gated high-impact actions, analyst decision record capture) | SOC/CIRT Lead | Team | 88h | £20,000 |
| Integrate with SIEM/case management/ticketing and implement audit-ready evidence generation (model versioning, contributing signals, decision logs, immutable retention) | Operations Lead | Enterprise | 72h | £10,000 |
| Operationalise continuous improvement (model drift/adversarial monitoring, retraining cadence, change control for model updates, escalation rules) | Security Engineer | Department | 64h | £8,000 |

**Total Estimated Effort:** 520h  
**Total Estimated Cost:** £138,000

###### Actions Required for Compliance

- [ ] Define the scope for predictive analytics across enterprise information technology (IT) services, operational technology (OT) network segments, and on-premises security monitoring sensors.
- [ ] Use machine learning to help find threats and link related activity, using combined system data to produce predictive risk scores.
- [ ] Add behavioural anomaly detection, then turn any detected anomalies into forward-looking risk scores with confidence levels.
- [ ] Link related or predicted findings to the MITRE ATT&CK tactics and techniques, and record the MITRE ATT&CK identifiers (IDs) in the case records.
- [ ] Set up adaptive response workflows that add relevant context and automatically carry out only low-impact actions
- [ ] Require a human to approve high-impact containment actions, and keep a record of the analyst’s decisions with supporting evidence.
- [ ] Set a regular schedule for updating and retraining the model, and put in place monitoring for model drift and attempts to bypass it, with clear escalation thresholds.


---

### RA-5 — Vulnerability Monitoring and Scanning (Control)

This requirement is about finding known security weaknesses in your systems early, before criminals can take advantage of them. If you do not check regularly, problems in software, system settings, or newly updated components can go unnoticed. This can create gaps that may lead to data loss, service disruption, or unauthorised access.

To meet this expectation, the organisation must:
- Monitor and scan hosted applications and on-premises system components every week.
- Run checks immediately after any patch or firmware update for on-premises components.
- Run checks immediately after any code or configuration change for hosted applications.
- Carry out random scans once every month.

The organisation must use tools and methods that work well together, can be updated quickly when new weaknesses are discovered, and can automatically:
- identify what is affected,
- produce consistent test checklists, and
- estimate the potential impact.

The organisation must then:
- review the scan results, and
- fix genuine issues within risk-based timeframes: **Critical within 7 days, High within 15 days, Medium within 30 days, and Low within 60 days**.

Finally, it must share the findings with the **Chief Information Security Officer (CISO)** and the vulnerability management team, so similar problems can be prevented elsewhere.

##### SCAP/OVAL weekly + change-triggered vulnerability scanning with SLA triage

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define scan scope, asset-to-profile mapping, and SLA banding (Critical/High/Medium/Low) for on-prem components vs hosted applications | Compliance Manager | Enterprise | 24h | — |
| Configure standards-based vulnerability identification (CVE naming, CVSS-derived severity/impact) and enable SCAP/OVAL-validated checks where available | Security Engineer | Enterprise | 40h | — |
| Build scan scheduling automation: weekly cadence, deterministic random monthly cohort selection (with logged cohort evidence), and change-triggered scans after patch/firmware (on-prem) and code/config changes (hosted) | DevOps Lead | Enterprise | 56h | — |
| Implement evidence retention and auditability: link scan runs to change events, store scan reports/results, and retain content/version timestamps for audit | Operations Lead | Enterprise | 32h | — |
| Integrate scan results into triage-to-remediation workflow: initial analysis/false-positive handling, routing to vulnerability management tickets with CVE, affected components, and computed impact; enforce SLA targets | Vulnerability Management Team | Enterprise | 48h | — |
| Establish tool/content update capability and operational process: prompt updates on new vulnerability announcements, record update timestamps/content versions, and validate update effectiveness | Cyber Security Lead | Enterprise | 24h | £6,000 |
| Deliver reporting dashboards and scheduled summaries for vulnerability management team and CISO, including trends and SLA breach reporting | Service Delivery Manager | Enterprise | 20h | — |

**Total Estimated Effort:** 244h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Create separate vulnerability scan profiles for on-premises system components and hosted applications, then assign each asset to the correct profile and service level agreement (SLA) band.
- [ ] Set up the scanner to identify vulnerabilities using Common Vulnerabilities and Exposures (CVE) information. Where supported, turn on Security Content Automation Protocol (SCAP) and Open Vulnerability and Assessment Language (OVAL) checks, and make sure the results include the CVE reference and severity/impact measures.
- [ ] Set up automated scanning to run every week for monitoring and to run random scans each month for selected cohorts, with the cohort selection recorded in logs.
- [ ] Link scan start times to change management so scans run straight after on-premises patching and firmware updates, and after hosted application code and configuration changes.
- [ ] Automatically upload scan results into the vulnerability management process and create repair (remediation) tickets that include supporting evidence and Common Vulnerabilities and Exposures (CVE) details.
- [ ] Set up and document a process for updating vulnerability tools and content, and record the date and time of each update and the version of the content.
- [ ] Set up regular reporting to the Chief Information Security Officer (CISO) and the vulnerability management team, showing security findings, trends, and whether service-level agreements (SLAs) are being met.


---

#### RA-5.2 — Update Vulnerabilities to Be Scanned (Enhancement)

This requirement is about making sure the list of known security weaknesses that your scanning checks for is always current before each new scan, and also whenever new weaknesses are discovered and reported. If you use an out-of-date list, you may not detect newly found problems, which could give attackers an opportunity to exploit them before you have a chance to fix them or reduce the risk.

To meet this expectation, the organisation must update the vulnerability list before every new scan and whenever new vulnerabilities are identified and reported. Updates must happen at least weekly, even if there are no new items. The most recently updated list must be used for the next scan.

The organisation must also keep clear records showing when the list was updated and the reason for each update. Named individuals should be responsible for keeping the list up to date and for reviewing scan results. The overall scanning approach must be documented, so it is clear how updates are applied and how scan findings are tracked through to fixing the issues and any follow-up checks.

##### Automate vulnerability feed refresh and enforce pre-scan scan gate

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define authoritative vulnerability sources and standardise scanner feed/update configuration (including mapping to “latest feed version/hash” used by the scanner) | System Design Authority | Enterprise | 16h | — |
| Build automated weekly feed refresh job (scheduler/CI runner) that updates feeds, validates success, and captures evidence (feed name, version/hash, update timestamp, source/reason) | DevOps Lead | Enterprise | 32h | — |
| Implement event-driven on-demand refresh trigger (integrate with vendor/CERT/advisory notifications or webhook mechanism; ensure refresh completes before next scan) | Platform Engineer | Enterprise | 24h | £3,000 |
| Implement scan gate in scan orchestration layer (hard block scan start unless scanner is configured to latest available feed version and refresh meets policy window; raise alert on failure) | Security Engineer | Enterprise | 40h | — |
| Persist append-only audit evidence and link feed update to scan runs (store scan ID ↔ feed version/hash ↔ update timestamp; ensure tamper-evident retention) | Compliance Manager | Enterprise | 24h | £2,500 |
| Update scanning runbook/system security plan with the pre-scan gate and feed update workflow (roles, triggers, evidence requirements, escalation paths) | Compliance Manager | Enterprise | 16h | — |
| Execute end-to-end testing and evidence validation (unit/integration tests for gate logic, refresh success/failure scenarios, and audit record completeness) | Quality Assurance Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 176h  
**Total Estimated Cost:** £5,500

###### Actions Required for Compliance

- [ ] Choose and set up how the scanner receives vulnerability updates, including the approved, trusted sources it will use.
- [ ] Set up an automated job to refresh the feed every week, and record the feed version (or hash), the date and time, and the source and reason for the refresh.
- [ ] Set up event-based triggers so that vulnerability feeds update immediately when new vulnerabilities are identified and reported.
- [ ] Add a “scan gate” in the scan orchestration process to prevent a scan from starting unless the latest feed version is being used.
- [ ] Store audit evidence that cannot be changed, linking every feed update to every scan run (scan ID ↔ feed version or hash ↔ timestamp).
- [ ] Assign named responsibility for carrying out and checking feed updates, and for reviewing scan results, using the organisation’s workflow tools.
- [ ] Update the scanning runbook and system security plan to describe the pre-scan approval step (“pre-scan gate”) and the update schedule (weekly and also triggered by relevant events).


---

#### RA-5.3 — Breadth and Depth of Coverage (Enhancement)

This requirement is about making sure your vulnerability scanning is neither too limited nor too superficial. You should search for known security weaknesses across the right parts of your systems, at the level where you can actually fix them. If you do not set clear coverage targets, important risks may be missed—for example, if some systems, types of systems, or more critical areas are not scanned, or if the results are reported in a way that does not clearly show which specific part needs attention.

To meet this expectation, the organisation must define and document:
- how widely it will scan (for example, what proportion of components, which system types, and which criticality levels), and  
- how deeply it will scan (for example, whether checks are done at component, module, or subsystem level).

The organisation must then ensure the scanning tools can meet these targets, are configured to do so, and that the tool settings are documented. If one tool is not enough, additional tools must be used. The agreed scanning breadth and depth must be recorded as evidence in the vulnerability scanning assessment.

##### Define and evidence vulnerability scan breadth/depth targets

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Build the Coverage Model linking authoritative inventory/asset data to scanning scope and reporting granularity (fields: asset/system type, environment, criticality tier; plus design-level mapping keys) | Cyber Security Lead | Enterprise | 24h | — |
| Define measurable breadth targets with explicit exceptions and compensating controls (e.g., % of eligible components by criticality tier/system type; or vulnerability-category/count checks) | Compliance Manager | Enterprise | 16h | — |
| Define measurable depth targets using system design levels (component/module/subsystem/element) and document mapping rules and allowed exceptions (e.g., host-level only where justified) | System Design Authority | Enterprise | 16h | — |
| Map scanner types/capabilities to the model and identify gaps (authenticated network/host, web/API, container/image, SCA/dependency), including a decision on whether additional tools or configurations are required | Cyber Security Lead | Enterprise | 20h | — |
| Produce scanner scope/configuration requirements and evidence mapping (inclusion/exclusion rules derived from inventory/criticality tiers; identifier traceability from scan output to design-level mapping) | Infrastructure Lead | Enterprise | 18h | — |
| Create and maintain tool configuration documentation per scanner profile (cadence, authentication/credential scope, ports/protocols, exclusions, mapping rules that determine depth) | DevOps Lead | Enterprise | 14h | — |
| Implement scan-cycle evidence pack template and run the most recent scan cycle to evidence actual breadth coverage, depth mapping performance, and sufficiency rationale with exception register | Project Manager | Enterprise | 22h | — |

**Total Estimated Effort:** 130h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Define a vulnerability scanning coverage approach that links the organisation’s official asset records to overall coverage goals and to deeper testing goals for each system design level.
- [ ] Set measurable coverage targets (for example, the percentage of components in each criticality tier and/or scanning all assets of specified system types) and record any exceptions.
- [ ] Set depth targets using system design terms (for example, component, module, subsystem, element) and define the required rules for mapping findings to the design.
- [ ] Choose and link the right scanner tool types to the coverage model, and add or configure extra tools where a single tool cannot provide the required level of detail.
- [ ] Set up scanner profiles so the scan scope and the output identifiers match the coverage plan (what is included or excluded by tier and type, and how it maps to the design level).
- [ ] Document scanner configuration details that affect what is covered, including how often scans run (cadence), what login or credentials are used (authentication and credential scope), which network connections are allowed (ports and protocols), what is left out (exclusions), and how results are matched to systems (mapping rules)
- [ ] Produce evidence for each scan cycle that shows (1) how much of the required coverage was achieved and (2) how well each item was mapped in depth, including why the coverage is considered sufficient and any exceptions.


---

#### RA-5.4 — Discoverable Information (Enhancement)

This requirement is about making sure that anything your systems accidentally make public is quickly identified and dealt with. If information that should not be public is found through normal searching or through what your systems unintentionally reveal, criminals could use it to attack you more effectively, work out how your services operate, or find easier ways to get in.

To meet this expectation, when the organisation confirms with evidence that specific information about a system can be found publicly, it must:
- notify the system owner and the Chief Information Security Officer,
- remove the information from public access or restrict it so it is no longer freely available, and
- update the system settings so the same or similar exposure is less likely to happen again.

The organisation must also record what was found, what actions were taken, who is responsible, and follow the work through to completion. It must keep clear evidence and any relevant test, risk, incident, and audit records, and ensure the right people and processes are used and linked to the system’s security documentation where applicable.

##### External discoverability monitoring with evidence-led remediation

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define RA-5(4) external discoverability scope, evidence schema, and “discoverable” criteria (URLs, HTTP/TLS/DNS fingerprints, headers/metadata, timestamps) including evidence capture requirements and audit fields | Compliance Manager | Enterprise | 24h | — |
| Select and procure/confirm enterprise-approved external exposure monitoring approach (e.g., Attack Surface Management tooling) and evidence storage mechanism (ticketing/workflow integration + immutable evidence retention) | Project Manager | Enterprise | 16h | £30,000 |
| Design and implement the confirmation gate workflow (external reproducibility checks, evidence validation rules, deduplication, severity mapping, and audit trail) integrated with the evidence schema | System Design Authority | Enterprise | 40h | — |
| Implement deception exclusion controls via approved deception registry/allowlist integration (match logic, audit logging, and “no RA-5(4) trigger” enforcement) | Security Engineer | Enterprise | 24h | — |
| Build the RA-5(4) corrective action trigger and remediation workflow (notify system owner + security leadership, create/assign corrective action record, enforce required remediation steps, and link evidence before/after) | Software Lead | Enterprise | 40h | — |
| Implement re-validation automation (post-remediation external checks, before/after evidence attachment, closure criteria, and reporting dashboards for audit) | DevOps Lead | Enterprise | 32h | — |
| Operationalise: runbooks, training, and governance (SLA/ownership, change control hooks for remediation, periodic tuning of checks, and audit readiness testing) | Service Delivery Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 200h  
**Total Estimated Cost:** £30,000

###### Actions Required for Compliance

- [ ] Define what parts of the application are allowed to be found from outside (internet-facing components), which environments are included, and what proof (evidence) is required.
- [ ] Set up monitoring of external-facing systems to spot potential information leaks. This includes checking network endpoints, how content is indexed, visible banners and metadata, whether storage is publicly accessible, and identifying Transport Layer Security (TLS) and Domain Name System (DNS) fingerprints.
- [ ] Set up a confirmation step that requires repeatable external proof for every candidate finding.
- [ ] Create and keep an approved deception register (allowlist) and ensure that any matching decoy results are excluded.
- [ ] Integrate the monitoring process with IT service management (ITSM) or ticketing so that the system owner and the chief information security officer (CISO) are notified and corrective actions for RA-5(4) are opened.
- [ ] Set up configuration “remediation” work instructions to remove or limit information that can be found, and to reduce the risk of future exposure.
- [ ] After the issue has been fixed, re-scan or re-test it. Attach before-and-after evidence to the corrective action record until the action is closed.


---

#### RA-5.5 — Privileged Access (Enhancement)

This requirement is about ensuring that only the right people can use extra-powerful access to the specific production and staging servers used for vulnerability scanning. This includes any classified enclaves and any systems that hold health information under the Health Insurance Portability and Accountability Act (HIPAA) or other personal information, and it must be used only for approved testing work.  

Without these controls, sensitive systems could be accessed for the wrong reasons, scanning could be carried out without the required checks, or access could be misused or go unnoticed—raising the risk of data exposure or service disruption.  

To meet this expectation, the organisation must:  
- Keep a documented list of the approved scan targets and the exact scanning activities that require elevated access.  
- Authorise privileged access only for those specific activities.  
- Allow privileged access only to named individuals or staff authorised through role-based access control (RBAC).  
- Require that scanning is carried out only after a successful login.  
- Use approved credentials.  
- Record and retain evidence showing who accessed what, and when.  
- Monitor usage and make decisions based on its risk policy, scanning procedures, the system security plan, and documented system design and configuration settings.

##### Purpose-scoped privileged access for authorised scan targets

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Build authoritative scan-target inventory (prod + staging) with asset identifiers, environment, sensitivity flags, and allow-listed scan types; include change control workflow and ownership | Vulnerability Management Lead | Enterprise | 40h | — |
| Define privileged scanning authorisation scopes (authenticated vuln scanning, config compliance checks, credentialed web app testing) and map each scope to the exact privileged capability (PAM role/sudo group/app test role/credentialed test account) | Security Architect | Enterprise | 32h | — |
| Design PAM/JIT policy model to validate requests against inventory + scopes; implement session scoping (target(s) + scope), short-lived elevation, and deny-by-default for non-authorised targets/scopes | System Design Authority | Enterprise | 48h | — |
| Integrate PAM/JIT with enterprise identity provider for authenticated access; implement request fields (target component, activity scope, justification/change reference) and enforce approved automation identities | IAM Architect | Enterprise | 40h | — |
| Configure session recording and evidence capture (who/what/when/which target/scope/approval outcome/session timing/actions where available) and ensure audit-ready log schema | Security Engineer | Enterprise | 24h | — |
| Implement SIEM forwarding, monitoring, and alerting rules for policy-violation patterns (e.g., scope/target mismatch, elevation attempts to non-authorised targets, elevation outside approved scanning windows) | SIEM/Monitoring Engineer | Enterprise | 24h | £12,000 |
| Execute end-to-end testing and acceptance validation (positive/negative cases, classified/HIPAA/PII sensitivity paths, authenticated-only enforcement, evidence completeness) and produce implementation sign-off pack | Project Manager | Enterprise | 32h | — |

**Total Estimated Effort:** 260h  
**Total Estimated Cost:** £12,000

###### Actions Required for Compliance

- [ ] Create and keep an approved (allow-listed) list of the servers used for production and staging scanning, including servers in classified enclaves and servers marked for Health Insurance Portability and Accountability Act (HIPAA) and personally identifiable information (PII).
- [ ] Set the boundaries (scopes) for privileged scanning activities for authenticated vulnerability scanning, configuration compliance checks, and credentialed web application testing. Then link each scope to the specific privileged capability it requires.
- [ ] Set up privileged access management (PAM) and just-in-time (JIT) access so that any request to elevate permissions must clearly state the target component and the activity scope, and the request is checked against the approved allow-list inventory and the defined scope rules.
- [ ] Only allow privileged access for the duration of the current session, and block any attempt to increase permissions when the requested access scope and target are not authorised.
- [ ] Integrate privileged access management (PAM) with the organisation’s identity provider to ensure that only verified users (people) and approved automated accounts can run privileged scanning sessions.
- [ ] Turn on logging for privileged scanning sessions and access approvals, and send those events to the security information and event management (SIEM) system so they can be monitored and kept for the required retention period.
- [ ] Set up security information and event management (SIEM) alerts to detect violations of the privileged access policy, such as attempts to access unauthorised targets or scanning outside approved scanning scopes.


---

#### RA-5.6 — Automated Trend Analyses (Enhancement)

This requirement is about using automated checks to track how security weaknesses change over time, not just finding them once. By comparing the results of several vulnerability scans, the organisation can identify worrying patterns, such as the same weak spots repeatedly returning, weaknesses steadily increasing, or the same areas being affected again and again. Without this, problems can be missed, repeated, or allowed to grow until they are exploited.

To meet this requirement, the organisation must set out in its risk and scanning procedures how it will carry out automated trend analysis by using scan comparison reports. It must ensure scans are compared across different dates and use automated tools to produce and record the trend findings. It must keep the original scan results and the trend outputs so they can be reviewed later, assign clear responsibilities for running the scans and analysing the results, and include this approach in system security planning and design records.

The organisation should also be able to provide the relevant documents and evidence, and show that the trend findings lead to clear follow-up actions.

##### Automated vulnerability scan trend analysis via scan comparison reports

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define the scan-trend workflow and RA-5(6) parameters (cadence, minimum scan runs, comparison window, required outputs, exception handling for scope/profile/tool changes) | Compliance Manager | Enterprise | 16h | — |
| Design the data model for scan comparison (scan run metadata, asset identifiers, vulnerability identifiers, severity mapping, scope/profile attributes, timestamps) and define normalisation rules | System Design Authority | Enterprise | 24h | — |
| Implement automated ingestion of scan exports into a central trend store (parsing, validation, deduplication, metadata capture, retention tagging) | Platform Engineer | Enterprise | 40h | £6,000 |
| Implement comparison logic to generate scan comparison reports across at least two time points (recurring vulnerabilities, increasing count/severity, repeatedly affected assets, exception flags) | Software Lead | Enterprise | 48h | £4,000 |
| Build and publish analyst-facing trend outputs (dashboard/report templates) and integrate with vulnerability remediation workflow (ticket creation/prioritisation rules for recurring patterns) | Operations Lead | Enterprise | 32h | £3,000 |
| Establish audit-ready evidence retention and traceability (link scan runs → comparison parameters → generated trend outputs; store tool/version metadata; access controls) | Data Protection Officer | Enterprise | 20h | — |
| Conduct end-to-end testing, including regression scenarios for inconsistent asset identifiers and severity mapping, and produce implementation evidence pack for RA-5(6) | Quality Assurance Lead | Enterprise | 24h | £2,000 |
| Pilot rollout and operational handover (runbook, monitoring/alerting for pipeline failures, analyst guidance, and first two scan-cycle validations) | Service Delivery Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 248h  
**Total Estimated Cost:** £15,000

###### Actions Required for Compliance

- [ ] Define the vulnerability scan trend analysis process in the vulnerability scanning and risk documentation, including its schedule (cadence), the required time window for each scan, and the required outputs.
- [ ] Set up automated importing of vulnerability scan results into the comparison and trend feature, using scanner application programming interfaces (APIs) or export processes.
- [ ] Apply consistent rules to match assets and to map vulnerability identifiers to their severity levels across all scan runs.
- [ ] Enable automated generation of scan comparison and trend reports that use multiple scan dates and times.
- [ ] Store the original scan results and the generated trend outputs with dates and times, the scanning tool and version details, and the comparison settings, so they can be used as audit evidence.
- [ ] Set up a process that sends recurring-pattern trend findings to the remediation ticketing and prioritisation system, and records the follow-up actions taken.


---

#### RA-5.8 — Review Historic Audit Logs (Enhancement)

This requirement is about checking the past to see whether a newly identified weakness in a specific system has already been used by an attacker before. If the same weakness was exploited in the previous 365 days, it could indicate the organisation has already been breached, with data potentially taken or changed, and the effects may have lasted longer than anyone realised.  

To meet this expectation, the organisation must clearly identify the exact system in scope and review its historical audit records for the previous 365 days. It must use the documented details of the weakness to look for clear signs that it was exploited.  

The organisation must record whether any prior exploitation was found, and keep the key evidence and the approach used so the review can be repeated and checked by someone else.

##### SIEM workflow to review prior exploitation for 365 days

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define RA-5(8) workflow requirements and data contract (inputs/outputs): system identifier, time period (default 365 days), vulnerability identifier, detection date anchor rules, decision outcomes, evidence pack schema | Compliance Manager | Enterprise | 16h | — |
| Build parameterised SIEM/SOAR correlation template (vulnerability-to-log) with immutable template/query versioning and deterministic time-window handling (start/end, timezone normalisation) | Security Engineer | Enterprise | 40h | £6,000 |
| Implement system → log source mapping and required event field normalisation (identity fields, device IDs, service accounts, SSO subject IDs) including query-ready field aliases | Platform Engineer | Enterprise | 32h | £4,000 |
| Develop and test exploitation-indicator query logic per vulnerability type (e.g., suspicious auth patterns, unauthorised API/admin actions, command execution/web exploit attempts, privilege escalation, abnormal process/file activity) with coverage for “no matches” evidence | Cyber Security Lead | Enterprise | 48h | — |
| Evidence pack automation: generate auditable outputs per run (template version, exact time window, log sources queried, matched event extracts or explicit no-match statement, reviewer notes/assumptions/limitations) | Operations Lead | Enterprise | 24h | — |
| Integrate workflow outcome recording into vulnerability/case management system with linkages to vulnerability record and evidence pack (including access controls and audit logging of the workflow run) | Service Delivery Manager | Enterprise | 20h | £2,500 |
| Implement repeatability quality gate: second-run/reviewer re-execution for a sample set using the same template version and time window; define acceptance criteria and mismatch documentation process | Quality Assurance Lead | Enterprise | 24h | — |
| End-to-end validation and pilot rollout (select representative systems and vulnerabilities), including operational runbook, monitoring/alerting for workflow failures, and sign-off against acceptance criteria | Project Manager | Enterprise | 32h | £3,000 |

**Total Estimated Effort:** 236h  
**Total Estimated Cost:** £15,500

###### Actions Required for Compliance

- [ ] Define and keep up to date an official list that links each affected system (ra-05.08_odp.01) to the log sources that contain the relevant audit events.
- [ ] Create a parameterised security information and event management (SIEM) and security orchestration, automation and response (SOAR) correlation template that takes the system and time period (ra-05.08_odp.02) as inputs, and sets the review window precisely.
- [ ] Add vulnerability-specific exploitation indicators to the template by defining the relevant event types and fields, and the query logic, based on the vulnerability record.
- [ ] Implement evidence pack generation that records the template version, the exact time window used, the log sources that were searched, and the event extracts that matched.
- [ ] Record the review result (“previous exploitation found” versus “no previous exploitation found”) in the case and vulnerability management system, and include a link to the evidence pack.
- [ ] Run a repeatability check by re-running the same template version for the same time window on a sample of reviews, and record any objective differences found.


---

#### RA-5.10 — Correlate Scanning Information (Enhancement)

This requirement is not only about finding individual security weaknesses. It is about working out whether those weaknesses could be combined into a realistic, step-by-step route that an attacker could use to break in and cause harm. Without this, your organisation might fix separate issues while missing the overall risk. For example, an attacker could use one weakness to reach another system or component, then use additional weaknesses to increase the damage—particularly during technology changes, such as moving from older network settings to newer ones where some parts may be missed.  

To meet this expectation, the organisation must take the results from its vulnerability scanning tools and analyse them together to identify any “attack paths” that involve more than one weakness and more than one step through connected systems or components, including during transitions such as from Internet Protocol version 4 (IPv4) to Internet Protocol version 6 (IPv6). It must document how this linking is done, assign named people to carry out the analysis and oversee the decisions, use the findings in risk assessment, and keep clear records and logs showing what was concluded and that the work was reviewed.

##### Correlate scan findings into multi-hop, multi-vulnerability attack paths

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define internal normalised schema for scan findings (asset/service identifiers, ports/protocol, CVE/CWE, evidence, scan window, confidence/severity) and mapping rules per supported scanner format | Security Analytics Engineer | Enterprise | 24h | — |
| Implement scan ingestion and normalisation pipeline (parsers, validation, deduplication, time-window handling, confidence/severity standardisation) with automated unit/integration tests | Software Lead | Enterprise | 56h | — |
| Design and implement dual-stack reachability model (graph data model, ingestion of network/service relationships, IPv4/IPv6 distinct nodes, routing/DNS/LB/trust edges where available) | Architect | Enterprise | 48h | — |
| Build correlation engine to map findings to graph nodes and compute candidate attack paths with multi-hop (2+ hops) and multi-vulnerability (2+ distinct weaknesses) criteria, including transition-aware IPv4→IPv6 logic | Security Engineer | Enterprise | 72h | — |
| Implement auditable correlation records (path ID, hop list, vulnerability chain per hop, scan window, evidence links to originating findings, explicit “no qualifying vector” outcomes) and immutable storage/export | Compliance Manager | Enterprise | 40h | — |
| Integrate correlation outputs into risk assessment workflow (export to ticketing/risk register with correlation record IDs, scan windows, and decision rationale) and add operational runbooks for triage | Project Manager | Enterprise | 32h | — |
| Performance, scalability, and governance hardening (data retention, access controls, logging, monitoring dashboards, and audit-ready reporting for correlation runs) | Operations Lead | Enterprise | 32h | £6,000 |
| Pilot on representative datasets (including known chained weaknesses and IPv4/IPv6 transition scenarios), validate acceptance criteria, and remediate gaps before rollout | Quality Assurance Lead | Enterprise | 32h | — |

**Total Estimated Effort:** 316h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Define a standard internal format for recording vulnerability scan results, including the affected asset or service, the port and protocol, the Common Vulnerabilities and Exposures (CVE) and Common Weakness Enumeration (CWE) references, supporting evidence, and the time period when the scan was run.
- [ ] Create or update an asset or service reachability model that recognises both Internet Protocol version 4 (IPv4) and Internet Protocol version 6 (IPv6) exposure and routes.
- [ ] Match each scan result to the relevant node(s) in the reachability graph, and save links that trace each result back to the original scanner evidence.
- [ ] Set up attack-path correlation rules that only select attack paths that include **at least 2 steps (hops)** and **at least 2 different exploitable weaknesses** across the full chain.
- [ ] Create audit-ready correlation records for every result, whether it qualifies or not. Each record must include the hop list, the vulnerability chain, and references to the scan time window.
- [ ] Send the correlation results into the organisation’s risk assessment process, including the correlation record reference IDs and links to the supporting evidence so they can be reviewed.


---

#### RA-5.11 — Public Disclosure Program (Enhancement)

This requirement is about making it easy and safe for people outside the organisation to report weaknesses they find, so the organisation can fix them quickly. If there is no clear public way to report suspected problems, important warnings may be missed, delayed, or dealt with informally. This can give criminals more time to take advantage of the weakness and can lead to avoidable disruption, financial loss, or harm to customers.

The organisation is expected to set up a public, easy-to-find way to report suspected vulnerabilities in its systems and related parts (for example, a dedicated web page or contact method). It must also publish clear, plain-language instructions that explicitly welcome reports made in good faith and explain how the reporter can share the details with the organisation.

The organisation must not require that the reporter keeps the issue secret indefinitely. However, it may ask for a specific, reasonable time period to allow the organisation to investigate and fix the problem properly.

##### Public vulnerability reporting channel with authorised disclosure window

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Draft plain-language “Responsible Vulnerability Disclosure” authorisation terms (good-faith testing allowed; prohibited activities; safe handling guidance; defined remediation window with extension mechanism) | Compliance Manager | Enterprise | 16h | — |
| Create publicly accessible disclosure landing page content and structure (URL, navigation placement, unauthenticated access, contact details, submission guidance, acknowledgement expectations) | Project Manager | Enterprise | 24h | — |
| Establish/confirm public intake channel (dedicated email alias and/or web form endpoint) and ensure it is discoverable from the public website/security menu without authentication | Operations Lead | Enterprise | 16h | £1,500 |
| Configure vulnerability intake and triage workflow in the ticketing/queue system (dedicated queue, required fields, routing rules to technical owners via asset/product mapping, triage/validation SLAs, status lifecycle) | Service Delivery Manager | Enterprise | 32h | £3,000 |
| Define and publish operational SLAs and responsibilities (acknowledgement within X business days; technical validation within Y days; escalation path; closure criteria; evidence requirements) and train relevant teams (SOC/IR liaison, application security, application owners) | Security Engineer | Enterprise | 24h | — |
| Implement audit-ready evidence retention and reporting (store published contact details, submission records, triage outcomes, remediation status, closure dates; periodic review cadence; sample end-to-end lifecycle evidence pack) | Data Protection Officer | Enterprise | 20h | — |
| Validate enterprise application routing and environment segregation (prod/test/DR handling rules; ensure correct technical owner receives reports; test with tabletop scenarios and one controlled test submission) | System Design Authority | Enterprise | 24h | — |

**Total Estimated Effort:** 180h  
**Total Estimated Cost:** £4,500

###### Actions Required for Compliance

- [ ] Publish an unauthenticated “Report a Security Vulnerability / Responsible Disclosure” page on the main website domain, and include a publicly available way to contact you.
- [ ] Draft and publish clear, plain-language authorisation terms for good-faith research and responsible disclosure, including a specific list of activities that are not authorised.
- [ ] Add a clear remediation disclosure timing statement (for example, a requested 60-day window), with an extension process for complex cases.
- [ ] Set up a dedicated “vulnerability intake” queue in the organisation’s ticketing system, with required submission fields and agreed triage service-level agreements (SLAs).
- [ ] Set up routing to the correct application or infrastructure owner by using asset and product mapping, taking into account the environment (production, test, or disaster recovery).
- [ ] Set up how long to keep records of submissions, triage decisions, remediation progress, and closure dates, and record the published web address and contact details in your security governance documentation.


---

### RA-6 — Technical Surveillance Countermeasures Survey (Control)

This requirement is about making sure your premises are regularly checked for hidden spying devices or other technical risks that could be used to break in or obtain sensitive information. Without these checks, someone could secretly place equipment or take advantage of weaknesses around entry points, server rooms, and areas where sensitive data is handled. This could lead to unauthorised access, disruption, or data theft.

The organisation must arrange for trained and qualified specialists to carry out a technical surveillance countermeasures survey at least once every quarter. The survey must cover all perimeter areas that can be accessed from outside, all server rooms, and all areas where sensitive data is processed. It must include visual, electronic, and physical inspections both outside and inside.

The organisation must also commission a targeted survey when there is suspected tampering, unexplained outages, unusual wireless or electromagnetic activity, or reports of suspicious devices. The organisation must record the results, keep evidence of the work completed, and use the findings to update risk assessments and plan any follow-up actions.

##### Quarterly TSCM survey service with indicator-triggered targeted resurvey

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define RA-6 TSCM scope map and survey boundaries (externally accessible perimeter areas, server rooms, sensitive data processing areas) including inside/outside coverage requirements | Compliance Manager | Enterprise | 16h | — |
| Draft and approve TSCM survey statement of work (SOW) covering quarterly cadence, required examination types (visual, electronic, physical), inside/outside execution, evidence format, and escalation/response expectations for indicators | Procurement / Contract Manager | Enterprise | 24h | — |
| Procure/contract qualified TSCM provider and confirm provider qualification checks, availability for quarterly schedule, and capacity for indicator-triggered targeted resurvey | Project Manager | Enterprise | 20h | £18,000 |
| Establish indicator-triggered targeted resurvey workflow (SOC trigger criteria, intake mechanism, approval gates, time-bound commissioning, affected location mapping, and provider notification process) | Security Operations / SOC Lead | Enterprise | 28h | — |
| Implement auditable evidence pack and reporting template (location-by-location examination record, dates, inside/outside, visual/electronic/physical results, high-level severity/likelihood, and recommended follow-up actions) | Compliance Manager | Enterprise | 16h | — |
| Execute first full quarterly TSCM survey across all scoped locations and obtain provider evidence pack | Operations Lead | Enterprise | 8h | £12,000 |
| Integrate survey outcomes into risk assessment and remediation tracking (update risk register inputs, create/assign remediation actions, and track to closure with audit trail) | Data Protection Officer | Enterprise | 20h | — |

Total Estimated Effort: **132 Hours**  
Total Estimated Cost: **£30,000**

###### Actions Required for Compliance

- [ ] Create and keep up to date a survey coverage map that includes every externally accessible boundary area, server room, and area where sensitive data is processed.
- [ ] Procure or contract a suitably qualified technical surveillance countermeasures (TSCM) provider, with contractual requirements for visual, electronic, and physical inspections both inside and outside.
- [ ] Plan and carry out technical surveillance countermeasures (TSCM) surveys every quarter, following the frequency set by the organisation.
- [ ] Set up and run an indicator-based process to request focused re-surveys when there are signs of possible tampering, unexplained outages, unusual wireless or electromagnetic activity, or reports that a device may be suspicious.
- [ ] Require location-by-location, auditable survey evidence, and store the reports in a controlled repository with defined retention rules.
- [ ] Update the risk assessment information and track remediation actions until they are completed, based on the findings from each survey.


---

### RA-7 — Risk Response (Control)

This requirement ensures that every issue identified in reviews, checks, and inspections is given a clear decision and a follow-up action, rather than being ignored. Without it, weaknesses in how the organisation protects information and personal data could remain unresolved, allowing mistakes, misuse, or breaches to continue for longer than necessary and damaging trust with customers and regulators.

The organisation must review every finding from security assessments, privacy assessments, monitoring activities, and audits. It must then decide what to do next based on the level of risk it has agreed it can accept. For each finding, it must record the chosen response and the reason. This may include fixing or strengthening controls immediately, creating a time-bound action plan when work cannot be completed right away, formally accepting the risk with justification, or deciding to share or transfer the risk, or avoid it.

Named staff must be responsible for making these decisions, carrying out any required fixes, using the relevant reports and records as the basis, and tracking each item through to completion.

##### Risk-response workflow for all security/privacy/audit findings

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define the end-to-end “findings intake → risk response → POA&M → closure” workflow, including required decision fields, risk-tolerance mapping rules, and closure gating criteria (evidence types + sign-off) | Compliance Manager | Enterprise | 24h | — |
| Design the standard findings normalisation schema (asset/service, data classification incl. privacy sensitivity, severity/likelihood/impact, evidence link model, risk tolerance reference) and publish integration mapping for each source type (security assessments, privacy assessments, monitoring, audits) | System Design Authority | Enterprise | 32h | — |
| Implement workflow automation in the chosen orchestration layer (ITSM + POA&M integration): intake, validation, mandatory field enforcement, accountable owner/implementer assignment, and POA&M auto-creation when mitigation is not immediate | DevOps Lead | Enterprise | 56h | £18,000 |
| Build POA&M automation and verification requirements: milestone generation, target dates, dependency tracking, evidence requirements per closure method, and linkage back to the originating finding and risk decision | Platform Engineer | Enterprise | 40h | — |
| Implement closure gating and audit-ready evidence capture: prevent closure until evidence is attached/verified and risk owner/approver sign-off is recorded; include immutable audit trail for decisions and changes | Security Engineer | Enterprise | 32h | — |
| Develop dashboards and periodic reporting (weekly/monthly) for open findings, response type distribution, POA&M ageing, overdue milestones, and “no response assigned” exceptions; include export for audit packs | Operations Lead | Enterprise | 24h | £6,000 |
| Execute end-to-end testing and pilot rollout (test cases across all finding source types, regression checks, user acceptance testing with risk/implementer roles, and go-live readiness) | Project Manager | Enterprise | 40h | £4,000 |
| Train stakeholders and update operational runbooks (workflow usage, decisioning expectations, evidence standards, escalation paths, and how to handle “accept/share/avoid” rationale) | Service Delivery Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 264h  
**Total Estimated Cost:** £28,000

###### Actions Required for Compliance

- [ ] Combine security information and event management (SIEM), security orchestration, automation and response (SOAR), vulnerability and configuration compliance checks, privacy assessment results, and audit management into one single “findings intake” workflow.
- [ ] Define and put in place a standard template for recording findings, including required links to supporting evidence and fields that reference the organisation’s agreed risk tolerance.
- [ ] Set up workflow decision rules so each decision must include: the response type, the risk-tolerance mapping, and a reason (required for accept, share, and avoid).
- [ ] Set up an automated rule to create a plan of action and milestones (POA&M) for mitigations that are not immediate, including required milestones and the evidence needed to confirm completion.
- [ ] Add closure gating so that findings can only be marked as closed after closure evidence is provided and the risk owner or approver has given named sign-off.
- [ ] Set up reporting dashboards showing open findings and progress against the plan of action and milestones (POA&M) over time, and agree regular review schedules with named accountable owners.


---

### RA-8 — Privacy Impact Assessments (Control)

This requirement is about making sure the organisation considers privacy impacts before it builds or buys anything that will handle people’s personal information, and before it starts any new way of collecting that information using technology. Without this, the organisation could collect too much information, use it in the wrong way, share it without proper protections, keep it for too long, or enable people to be contacted or targeted online or in person when they should not be—causing real harm and leading to legal or reputational damage.

To meet this expectation, the organisation must complete a clear, documented privacy assessment and record the result before starting the relevant work. The assessment must cover:
- what personal information will be handled,
- why it is needed,
- how it will be used and shared,
- the privacy risks, and
- specific steps to reduce those risks.

The assessment must be detailed enough to show privacy was considered from the earliest planning stage and throughout the full life of the information. It must also be kept up to date whenever technology, working practices, or other factors change the privacy risks.

##### PIA gate in delivery lifecycle with living, versioned records

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define PIA gate requirements and workflow acceptance criteria (triggers, required fields, approval roles, linkage rules to release artefacts) | Compliance Manager | Enterprise | 16h | — |
| Configure standardised PIA intake form in ALM/portfolio workflow (e.g., Jira/Azure DevOps/ServiceNow): PII processing/collection triggers, data categories, purposes, sharing/third parties, retention/erasure, cross-border, targeting/contact indicators | Project Manager | Enterprise | 40h | £12,000 |
| Implement controlled, versioned PIA template and generation logic (structured privacy requirements, risk register, mitigation mapping to design/operational controls, approval metadata, audit timestamps) | Data Protection Officer | Enterprise | 32h | £8,000 |
| Enforce the “gate” in delivery lifecycle (no initiation/procurement approval without approved PIA reference; no release/go-live approval without current PIA linked to release artefacts) | Operations Lead | Enterprise | 48h | £15,000 |
| Integrate living-document re-triggering with change management (automatic re-assessment triggers for new fields/integrations/purposes/retention/access model/targeting capability; ensure re-approval before change release) | Platform Engineer | Enterprise | 40h | £10,000 |
| Build audit-ready evidence repository (controlled storage, version history, approval records, initiative/release links, export/reporting for audits) | Security Engineer | Enterprise | 24h | £6,000 |
| Pilot and iterate with 2–3 representative initiatives (end-to-end testing of gate enforcement, evidence completeness, approval workflow, and remediation of workflow edge cases) | Quality Assurance Lead | Enterprise | 32h | — |
| Rollout, training, and operational handover (runbooks for privacy reviewers/system owners/change managers; training sessions; monitoring of gate compliance and exception handling) | Service Delivery Manager | Enterprise | 24h | £4,000 |

**Total Estimated Effort:** 276h  
**Total Estimated Cost:** £55,000

###### Actions Required for Compliance

- [ ] Define the personal information (PII) intake fields and the decision points in the delivery workflow, including: whether personal information is being processed, whether new personal information is being collected, whether there is a risk in contacting the person, and whether there are 10 or more identical questions.
- [ ] Create a controlled, versioned privacy impact assessment (PIA) template that requires privacy requirements, identified privacy risks, and mapped mitigations (planned safeguards).
- [ ] Set up portfolio and application lifecycle management (ALM) controls and release approval gates so that development, procurement, and go-live cannot proceed unless there is an approved privacy impact assessment (PIA) reference.
- [ ] Set up change management so that privacy impact assessment (PIA) reviews are automatically restarted whenever data fields, integrations, purposes, how long data is kept or deleted, or how people are contacted or targeted are changed.
- [ ] Set up a managed repository for privacy impact assessments (PIAs) that keeps a version history, records approval details, and includes links to the relevant initiative and release documents.
- [ ] Train system owners, system architects, and release managers on the PIA gate process and what evidence they must provide


---

### RA-9 — Criticality Analysis (Control)

This requirement is about deciding, before building or changing systems, which parts are genuinely critical to the organisation’s most important work—especially software services and connections that handle highly sensitive information or provide direct, unfiltered access. Without this step, teams may focus protection on the wrong areas, leaving the most damaging weaknesses undiscovered until it is too late—for example, when a key service fails, a dependency breaks, or an interface is exploited.

To meet this expectation, the organisation must analyse mission-critical systems, software services, and interfaces during architecture and design development, before any major design changes, and before upgrades are implemented and integrated. The analysis must break the system down into its missions, the functions that deliver them, and the hardware, software, and firmware that carry them out, including functions shared with other internal or external components.

The organisation must also consider legal and policy requirements, system needs, dependencies, and the impact of failure on organisational missions. It must treat any direct, unmediated access routes as critical. Finally, it must document the criticality decisions for each component or subcomponent and keep the analysis records available for review.

##### Criticality Gate in SDLC to analyse mission-critical components

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define RA-9 criticality gate scope and SDLC decision points (architecture/design development, major design changes, upgrades before implementation/integration) including criteria for Confidential/Secret data and unmediated access paths | Systems/Software Architect | Enterprise | 16h | — |
| Design the RA-9 criticality analysis artefact (data model + standard template) covering missions → functions → traceability to implementing components, interface/dependency lists (shared + external/system-of-systems), data sensitivity, failure impact, and explicit “unmediated access path” indicator | System Design Authority | Enterprise | 24h | — |
| Implement functional decomposition and traceability mapping guidance for engineers (work instructions, examples, and completeness checklist aligned to the template fields) | Security Engineer | Enterprise | 20h | — |
| Integrate the criticality gate into the change-management and architecture workflow (e.g., Jira/ServiceNow + architecture repository): required checklist/approval step, blocking rules for promotion/merge/release, and completeness validations (decomposition, interfaces, dependencies, final criticality decisions, unmediated access assessment) | DevOps Lead | Enterprise | 40h | £6,000 |
| Configure evidence storage and audit-ready linkage (version-controlled repository, immutable audit trail fields, approver identity and timestamps, linkage from design/change records to the completed artefact) | Platform Engineer | Enterprise | 24h | £2,500 |
| Run pilot on 1–2 representative systems and refine gate criteria/templates based on findings; produce sign-off evidence for operational readiness | Compliance Manager | Business Unit | 16h | — |
| Deliver training and rollout communications (engineer enablement sessions, governance/assurance briefing, and support model for completing the artefact) | Project Manager | Enterprise | 12h | — |

**Total Estimated Effort:** 152h  
**Total Estimated Cost:** £8,500

###### Actions Required for Compliance

- [ ] Define the scope for {{ra-09_odp.01}} and the required decision points for {{ra-09_odp.02}} within the architecture and change workflow.
- [ ] Create a criticality analysis template and data model that records: missions, functions, how each requirement can be traced, interfaces, dependencies, data sensitivity, and indicators of direct (unmediated) access.
- [ ] Set up a “criticality gate” workflow that stops architecture approval, code merging or release, and promotion until the RA-9 document is completed for the items in scope.
- [ ] Train systems and software architects to break down each mission-critical function into smaller parts, and to link every mission-critical function to the specific components and interfaces that will implement it.
- [ ] Add automated checks to confirm that the decomposition, the lists of interfaces and dependencies, and the final decisions on criticality are all included.
- [ ] Store and keep versions of the final criticality analysis evidence in a controlled repository. Link it to each design or change record, and record who approved it (their identity) along with the approval date and time.


---

### RA-10 — Threat Hunting (Control)

This requirement is about actively looking for hidden signs that an attacker may already be inside your systems, and then acting quickly to stop them. Without regular, structured searching, threats that get past everyday protections can go unnoticed, leading to data theft, fraud, disruption of services, or long-term damage before anyone realises what is happening.

The organisation is expected to set up and maintain an ongoing threat-hunting capability. This should include clear responsibilities for the people involved and the right support from system and network administrators. The organisation should regularly search its systems for observable signs of compromise, identify threats that existing safeguards do not catch, and monitor how those threats develop over time.

If threats are found, the organisation must take action to disrupt them. This threat-hunting activity must be carried out every day. The approach must be documented, evidence must be kept in records, and the capability must be included in relevant security planning. It should be aligned to the organisation’s risk priorities, supported by appropriate tools, and produce reports showing that it is operating as required.

##### Daily SIEM/SOAR threat hunting with auditable hunt evidence

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define daily threat-hunting scope, hypotheses, and evidence requirements (RA-10 frequency mapped to “daily” runs; in-scope environments; success criteria; audit evidence data model) | Compliance Manager | Enterprise | 24h | — |
| Design hunt evidence retention approach (immutable run records, query/content versioning, matched artefacts, analyst decisions, disruption outcomes; retention periods; access controls) | Data Protection Officer | Enterprise | 16h | — |
| Implement detection-as-code hunt content (version-controlled SIEM queries, enrichment logic for identity/asset criticality/baselines; test harness with sample datasets; coding standards) | Security Engineer | Department | 56h | £6,000 |
| Configure daily scheduled hunt jobs and reporting (time windows, run timestamps, content version stamping, per-run hunt report output; failure handling and alerting) | DevOps Lead | Department | 40h | £3,000 |
| Implement SOAR triage workflow with guardrails (case creation, enrichment, assignment, analyst approval gates for high-impact disruption; safe containment actions; rollback/exception handling) | Security Engineer | Department | 48h | £10,000 |
| Integrate disruption execution with network/identity controls (e.g., block at proxy/DNS/firewall, revoke sessions/disable accounts via approved interfaces; logging of actions and outcomes) | Infrastructure Lead | Department | 32h | £5,000 |
| Establish continuous improvement governance (weekly review cadence; false-positive tuning; threat-intel updates; change management for hunt content; audit readiness checks) | Project Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 240h  
**Total Estimated Cost:** £24,000

###### Actions Required for Compliance

- [ ] Record daily threat-hunting assumptions, what you will cover, and how you will measure success, aligned to your top risk priorities.
- [ ] Set up security information and event management (SIEM) “hunt” queries and enrichment steps for each hypothesis, using version control so changes are tracked.
- [ ] Run the hunt content every day and produce a separate hunt report for each run, including the time window and the content version.
- [ ] Set up security orchestration, automation and response (SOAR) workflows to sort alerts, add extra information, start investigations, and assign responsible owners so progress can be tracked.
- [ ] Create and put in place disruption playbooks, with analyst approval checkpoints for high-impact actions.
- [ ] Store audit-ready evidence that links each finding to the specific query/content version, the analyst’s decisions, and the resulting disruption outcomes.
- [ ] Run a weekly review to update the threat-hunting content based on results and new threat intelligence (information about potential threats).


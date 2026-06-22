### SR-1 — Policy and Procedures (Control)

This requirement is about making sure the organisation has clear, written rules for managing risks from suppliers, and that staff know exactly how to follow them. Without this, a weak or unreliable supplier could introduce harmful products, services, or ways of handling information, which could cause service disruption, financial loss, legal issues, or damage to trust.

To meet this expectation, the organisation must create, document, and publish an organisation-wide **Supply Chain Risk Management** policy and the supporting procedures. It must also appoint a **Supply Chain Risk Management Officer** to oversee the policy and procedures being developed, approved, and distributed.

The policy must explain its purpose, what it covers, the roles and responsibilities, the commitment from senior leadership, how different parts of the organisation work together, and how the organisation will check that the policy is being followed. It must also align with all relevant laws, directives, regulations, and internal guidance.

The policy must be reviewed and updated every year, and within 60 days of any major trigger. The procedures must be reviewed and updated every year, and within 30 days of any major trigger, including after supply chain assessments or audit findings, security incidents or breaches, or changes to relevant requirements.

##### Organisation-wide SCRM policy & procedures with SCRM Officer ownership

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Appoint and formally document the SCRM Officer role (RACI, authority, accountability, escalation path) and publish the role charter | Compliance Manager | Enterprise | 8h | — |
| Draft organisation-wide SCRM policy (single source of truth) covering SR family + supply-chain-related controls implemented elsewhere; include scope, roles/responsibilities, coordination model (security + privacy), enforcement/exception handling, and alignment to applicable requirements | Compliance Manager | Enterprise | 40h | — |
| Draft organisation-wide SCRM procedures (role-based, lifecycle-based: onboarding/intake, ongoing management, change/termination) with required inputs/outputs and auditable record-keeping | Compliance Manager | Enterprise | 56h | — |
| Define trigger-based update mechanism: create/maintain SCRM change register, specify triggering events, and document scheduling rules (policy within 60 days; procedures within 30 days) including ownership for assessment and approval | Project Manager | Enterprise | 24h | — |
| Establish security/privacy collaboration workflow for annual reviews and triggering updates (joint review agenda, sign-off process, evidence requirements, and version control governance) | Data Protection Officer | Enterprise | 24h | — |
| Dissemination and evidence pack: publish policy to executive leadership, CISO, procurement leadership, and SCRM Officer; publish procedures to procurement officers, vendor management, security engineering, and system owners; capture acknowledgements and retain audit evidence | Service Delivery Manager | Enterprise | 16h | — |
| Run first annual review rehearsal (table-top) and validate cadence against acceptance criteria (including evidence completeness and update timelines), then publish controlled version | Compliance Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 204h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Appoint a Supply Chain Risk Management (SCRM) Officer and formally record responsibility for developing, documenting, and sharing the information.
- [ ] Draft and get approval for an organisation-wide supply chain risk management (SCRM) policy. The policy must state its purpose, cover the scope of the “SR” family plus supply-chain-related controls that are handled in other documents, and clearly set out roles and responsibilities, including how security and privacy teams coordinate.
- [ ] Develop supplier relationship management (SCRM) procedures that include role-based step-by-step instructions and the required supporting documents and record-keeping, without repeating existing controls.
- [ ] Share the supply chain risk management (SCRM) policy with the executive leadership team, the chief information security officer (CISO), procurement leadership, and the SCRM Officer, and keep auditable proof that it was acknowledged.
- [ ] Share the supply chain risk management (SCRM) procedures with procurement officers, vendor management, security engineering, and system owners, and keep auditable proof that they acknowledged receipt.
- [ ] Set up a system (trigger register and workflow) to update the policy within 60 days and update the procedures within 30 days after the defined trigger events occur.
- [ ] Carry out an annual joint security and privacy review, then publish updated materials with version control and documented approvals.


---

### SR-2 — Supply Chain Risk Management Plan (Control)

This requirement is about making sure the organisation has a clear, up-to-date plan for managing risks that arise from using outside suppliers and partners. It must cover the full life of its systems—from early development and design, through making, buying, delivering, combining with other parts, running and maintaining, and finally disposing of them. Without this plan, harmful or counterfeit items could be introduced, products could be tampered with, poor practices could go unnoticed, or sensitive information about how the organisation works could be exposed. This could lead to service disruption, financial loss, or damage to trust.

The organisation must create a supply chain risk management plan that covers all these stages. It must review and update the plan at least once every year and within 30 days of any major threat, organisational change, or environmental change. The plan must also be protected so that only authorised people can view it and only authorised people can change it.

##### Governed SCRM plan covering full lifecycle with protected updates

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Draft the implementation-specific SCRM plan with mandatory lifecycle sections (R&D, design, manufacturing, acquisition, delivery, integration, operations & maintenance, disposal) and tailored scope for systems/components/services | Compliance Manager | Enterprise | 40h | — |
| Define supply chain risk tolerance, acceptable residual risk thresholds, and required mitigation strategies/controls (including trustworthy, secure, privacy-protective, and resilient requirements) | Cyber Security Lead | Enterprise | 24h | — |
| Create the lifecycle-linked risk evaluation process mapped to enterprise acquisition/SDLC gates (supplier onboarding, security requirements checklist, release/change gates, decommissioning/exit activities) | System Design Authority | Enterprise | 32h | — |
| Establish roles, responsibilities, and approval workflow (RACI), including who approves risk acceptance and who signs off plan updates; include evidence expectations for audits | Compliance Manager | Enterprise | 16h | — |
| Implement the “major change” trigger mechanism: define threat/incident/change register inputs, impact assessment steps, and an update workflow with an SLA to complete updates within 30 days | Project Manager | Enterprise | 24h | — |
| Set up controlled repository governance for the single source of truth plan: restricted read access, approval-based edit rights, immutable versioning, and audit trail configuration | Operations Lead | Enterprise | 20h | £3,000 |
| Produce governance artefacts and assurance pack: annual review procedure, change log templates, evidence checklist, and training/communication materials for plan users (procurement, security/privacy reviewers, system owners) | Service Delivery Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 172h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Create a supply chain risk management (SCRM) plan template that includes mandatory sections for research and development (R&D), design, manufacturing, purchasing, delivery, integration, operations and maintenance, and disposal.
- [ ] Define the level of supply chain risk the organisation is willing to accept and set the acceptable mitigation strategies and controls within the supply chain risk management (SCRM) plan.
- [ ] Create a mapping from the product lifecycle to the software development lifecycle (SDLC) and procurement activities, and reference this mapping in the supplier onboarding process and in the security requirements approval checkpoints.
- [ ] Create a RACI (responsible, accountable, consulted, informed) in the plan that covers who is responsible for plan ownership, procurement, security and privacy review, system ownership, and who approves risk acceptance and change sign-off.
- [ ] Set up a process and tracking list for major changes, so you can assess the impact and update the plan within 30 days.
- [ ] Store the supply chain risk management (SCRM) plan in a controlled repository with restricted read access, approval-based permission to make changes, and an unchangeable version and audit history.


---

#### SR-2.1 — Establish SCRM Team (Enhancement)

This requirement is about setting up a dedicated team to identify and manage risks from suppliers and outside partners before they cause disruption. Without a clear team, important warning signs about suppliers, contracts, or the technology and services they provide can be missed. This can lead to delays, poor quality, legal issues, privacy breaches, or systems failing when they are needed most.

The organisation must appoint a **Supply Chain Risk Management** team, led and supported by the risk executive, the **Chief Information Security Officer (CISO)**, a contracting officer, a supply chain or logistics lead, an IT lead, a privacy officer, legal counsel, a business continuity lead, and an acquisition lead. The team must:

- lead and support the work of identifying, assessing, and prioritising supplier risks  
- agree and define practical actions to reduce those risks  
- monitor supplier performance over time  
- ensure supply chain risks are considered during software development and when using third parties  

The team must also communicate with internal and external stakeholders. It must keep clear written records covering roles, strategy, and procedures (including supply chain protection), implementation plans, and links to relevant security and privacy planning. These documents must involve the appropriate people responsible for acquisition, security, privacy, enterprise risk, legal matters, and business continuity.

##### Establish chartered SCRM team with defined roles and activities

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Nominate and formally appoint all required SCRM role-holders (risk executive, contracting officer, supply chain/logistics lead, IT lead, privacy officer, legal counsel, business continuity lead, acquisition lead) with documented responsibilities | Project Manager | Enterprise | 8h | — |
| Draft the SCRM team charter (purpose, scope, decision rights incl. risk acceptance/escalation, meeting cadence, required outputs, governance and reporting lines) | Compliance Manager | Enterprise | 24h | — |
| Review, challenge, and obtain approvals/sign-off for the SCRM charter (Security, Legal, Privacy, Procurement/Acquisition, Business Continuity) and publish the final signed version | Compliance Manager | Enterprise | 16h | — |
| Define the end-to-end SCRM activity workflow (supplier intake/tiering, identify/assess/prioritise, mitigation definition, contract control requirements, ongoing monitoring, SDLC/third-party dependency governance, stakeholder communications) | Cyber Security Lead | Enterprise | 32h | — |
| Produce and publish the RACI mapping for all SCRM activities and interfaces (acquisition, legal, privacy, IT security, business continuity), including escalation paths and ownership of evidence | Compliance Manager | Enterprise | 16h | — |
| Embed SCRM checkpoints into SDLC and third-party dependency management (define mandatory gates, required inputs/outputs, evidence expectations, and how they are enforced through change/release governance) | System Design Authority | Enterprise | 40h | — |
| Establish stakeholder communication channels and operating rhythm (internal escalation, supplier engagement approach, questionnaire/remediation coordination, and performance reporting cadence) | Service Delivery Manager | Enterprise | 20h | — |

**Total Estimated Effort**: 156h  
**Total Estimated Cost**: £0

###### Actions Required for Compliance

- [ ] Appoint named responsible people for the risk executive, chief information security officer (CISO), contracting officer, supply chain and logistics lead, information technology (IT) lead, privacy officer, legal counsel, business continuity lead, and acquisition lead.
- [ ] Approve and publish a supply chain risk management (SCRM) charter that sets out the scope, decision-making responsibilities, escalation routes, meeting schedule, and the required SCRM deliverables.
- [ ] Document the supplier risk management (SCRM) workflow, including how you: identify, assess and prioritise risks; define and implement mitigations; monitor supplier performance; manage software development lifecycle (SDLC) and third-party dependencies; and communicate updates to stakeholders.
- [ ] Create and publish a RACI matrix that maps each supply chain risk management (SCRM) activity to the required roles (lead or support) and the points of contact with procurement (acquisition), legal, privacy, information technology (IT) security, and business continuity.
- [ ] Define software development lifecycle (SDLC) and third-party dependency checkpoints—covering what information is required, the review steps (gates) that must be completed, and what proof (evidence) must be provided—that the supplier risk management (SCRM) team will enforce through the organisation’s existing change and release approval process.
- [ ] Set up internal escalation and supplier engagement processes, including how risks are reported (risk intake), how information is collected from suppliers (questionnaires), how fixes are coordinated (remediation coordination), and how progress is regularly tracked and reported (monitoring and reporting cadence).


---

### SR-3 — Supply Chain Controls and Processes (Control)

This expectation is about making sure the organisations and suppliers you rely on to build, deliver, run, and maintain your on-site systems are properly checked, and that any issues are dealt with quickly. Without a clear, coordinated approach, a weak or dishonest supplier could introduce harmful software or hardware, or interfere with items during delivery, leaving your business exposed and unable to carry out its day-to-day work.

To meet this expectation, your organisation must set up a coordinated process—agreed with the supply chain risk lead and the system owner—to identify weaknesses in the supply chain and fix them. You must use supplier security reviews, checks that confirm where software and hardware came from and that it is genuine, and delivery requirements that make unauthorised interference obvious.

Finally, you must decide the specific steps you will use, put them into practice, and record them in your supply chain risk management plan so the approach can be repeated and independently checked.

##### Risk-based supplier lifecycle with remediation and evidence gates

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define scope, governance roles, and coordination model for supply chain risk (system/component scope, RACI between supply chain risk management lead and system owner, escalation routes) | Compliance Manager | Enterprise | 16h | — |
| Create and maintain supplier/component mapping (supplier-to-component inventory for on-premise software libraries, firmware, hardware, and integrator services; define in-scope inclusion rules) | Project Manager | Enterprise | 24h | — |
| Select and document vendor security assessment pack requirements (questionnaire/attestation items, evidence types, risk scoring approach, onboarding and reassessment cadence, triggers for ad-hoc reassessment) | Cyber Security Lead | Enterprise | 32h | — |
| Establish risk register and remediation workflow with evidence gates (fields, ownership, due dates, remediation options, escalation thresholds, closure approval process by system owner) | Compliance Manager | Enterprise | 24h | — |
| Implement procurement and receiving gates (procurement hold criteria, required assessment outcome/contract clauses, tamper-evident shipping verification steps, inspection evidence retention requirements) | Operations Lead | Business Unit | 24h | — |
| Produce the Supply Chain Risk Management Plan (end-to-end process narrative, control selection rationale, evidence artefacts, audit trail expectations, coordination points, reassessment triggers/cadence, receiving/provenance expectations) | Compliance Manager | Enterprise | 20h | — |
| Run pilot on a representative set of in-scope suppliers/components and validate evidence gates (execute onboarding assessments, record register entries, test escalation and closure, refine process documentation) | Service Delivery Manager | Department | 32h | — |
| Total Estimated Effort |  |  | **172h** | — |
| Total Estimated Cost |  |  | — | **£0** |

###### Actions Required for Compliance

- [ ] Identify the system components that are in scope and define the supply chain roles involved in coordination, including the supply chain risk management lead and the system owner.
- [ ] Create and keep up to date a list of suppliers and the components they provide for the on-premises system and its components.
- [ ] Create a vendor security assessment pack and use it for every in-scope supplier during onboarding, and then repeat it on a set schedule based on each supplier’s risk level.
- [ ] Set up a supply chain risk register process that records each risk finding, names a responsible owner, sets a deadline for fixing the issue, and keeps the supporting evidence and approval records for when the risk is closed.
- [ ] Put in place procurement checkpoints that require a decision result (and any required approval to accept risk) before placing orders with in-scope suppliers.
- [ ] Set up and carry out shipping receiving checks that make any tampering obvious, and keep the inspection records so the process can be reviewed during audits.
- [ ] In the supply chain risk management plan, document the chosen identification and remediation processes or controls, the events that trigger reassessment, the types of evidence to keep, and the escalation routes.


---

#### SR-3.1 — Diverse Supply Base (Enhancement)

This requirement is about not depending on just one supplier for the building blocks and support services your systems rely on. It matters because if a single supplier, developer, or logistics provider has an outage, goes out of business, is affected by a disaster, or their products are compromised, your organisation may struggle to replace critical components quickly. It could also be exposed through a single weak link.

To meet this expectation, the organisation must use a range of sources for critical items, including hardware, firmware, operating system images, container base images, third-party libraries, and managed security services. This includes using more than one supplier for replacement parts and services, and making sure that no single supplier or single location becomes the only point that could cause service unavailability or compromise.

The organisation should:
- document how it manages supply chain risk
- set acquisition and planning rules that require diverse sourcing
- keep records of what it uses and who provides it
- assign named responsibilities
- maintain a system security plan and related procedures showing how suppliers are identified and managed

##### Diverse sourcing for critical components and managed security services

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish Critical Supply Register template and governance (scope, data fields, ownership, review cadence, exception handling) | Compliance Manager | Enterprise | 16h | — |
| Populate Critical Supply Register for all `sr-3.1_prm_1` categories (critical hardware, firmware, OS images, container base images, third-party libraries, managed security services) including at least two approved sources and fulfilment locations where applicable | Supply Chain/Procurement Lead | Enterprise | 40h | — |
| Define diversity rules and equivalence criteria for acquisition planning (compatibility requirements, qualification thresholds, geography/fulfilment options, DR/dev/test mapping) and update acquisition/planning procedures | System Design Authority | Enterprise | 24h | — |
| Implement supplier qualification and approval gates (evidence requirements, approval workflow updates, prohibition on approving critical items without an approved alternate source recorded) | Project Manager | Enterprise | 32h | — |
| Contractualise continuity and substitution clauses for critical suppliers/providers (incident notification, delivery SLAs, right-to-replace/substitution, audit/evidence rights) and produce standard clause pack | Compliance Manager | Enterprise | 24h | — |
| Create inventory-to-source mapping approach and update change/release/configuration processes (CMDB/deployment manifest traceability for OS/container base images, third-party libraries, managed security services) | Change/Release Manager | Enterprise | 24h | — |
| Conduct control effectiveness review and exception management (identify any single-source gaps, document risk rationales/compensating controls, set time-bounded remediation plans, and prepare audit-ready evidence pack) | Cyber Security Lead | Enterprise | 20h | — |

Total Estimated Effort: **200h**  
Total Estimated Cost: **£0**

###### Actions Required for Compliance

- [ ] Create a Critical Supply Register for every item listed in `sr-3.1_prm_1`, and record the supplier or provider, the contract details, and the location(s) where the items are fulfilled.
- [ ] Update acquisition and planning procedures so that each critical item or service must be supported by at least two qualified sources, and record clear evidence showing how sources are considered equivalent.
- [ ] Set clear evidence requirements for qualifying suppliers and use approval checkpoints to ensure critical purchases cannot go ahead unless an approved alternative supplier is available.
- [ ] Add contract clauses for continuity and substitution, and for incident notification, for every critical supplier or provider.
- [ ] Create and keep an up-to-date record that links what is currently deployed (operating system and container base images, and third-party software libraries) and the managed security services in use to the approved suppliers and providers.
- [ ] Define and document a time-limited exception process for any unavoidable situation where there is only one source, using compensating controls.


---

#### SR-3.2 — Limitation of Harm (Enhancement)

This requirement is about making it harder for hostile outsiders to identify and take advantage of the organisation’s suppliers and delivery process. If we buy from unknown or unreliable sources, use unusual arrangements, or delay updates, an attacker could introduce a compromised product or service, or exploit weaknesses that have already been fixed elsewhere.  

To reduce this risk, the organisation must:  
- keep and use an approved list of permitted suppliers  
- use standard arrangements for purchases and deployments rather than custom ones (unless there is a documented and authorised reason)  
- follow agreed maintenance and update schedules so fixes are applied on time  

The organisation must also:  
- maintain a contingency plan for supply-chain disruptions  
- use different delivery routes where feasible  
- minimise the time between deciding to purchase and receiving the goods or services

##### Procurement gate enforcing approved vendors and standard configs

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish/refresh the approved vendor list schema (incl. legal entity identifiers, risk tier, approval status, expiry) and define waiver/exception workflow with approval authority and expiry | Procurement system owner (ERP/ITSM/Procurement Ops) | Enterprise | 40h | — |
| Define standardised configuration baselines for key procurement categories (e.g., hardened OS/app images, approved service profiles, reference architectures) and document allowed deviation types | Security architect | Enterprise | 56h | — |
| Create policy-as-code rule set and mapping to procurement fields (block non-approved vendors, missing/expired waivers, missing baseline version/deviation, missing maintenance/patch commitments, missing contingency/incident clause identifiers) | Cyber Security Lead | Enterprise | 72h | — |
| Integrate procurement gate into ERP/procurement workflow (requisition → purchase order conversion) including required data capture, validation, and exception handling with audit trail | Platform Engineer | Business Unit | 64h | £18,000 |
| Implement contract clause set identifiers and template enforcement (ensure supply-chain contingency/incident notification clauses are included and traceable to the purchase record) | Compliance Manager | Department | 32h | £6,000 |
| Capture decision-to-delivery timing evidence (decision date, order placement date, expected/actual delivery dates) and implement outlier flagging/reporting for review | Operations Lead | Enterprise | 40h | £4,000 |
| Configure audit evidence retention and reporting (retrievable evidence for at least 12 months; baseline/waiver/clause/schedule references; periodic compliance dashboards) | Compliance Manager | Enterprise | 40h | £3,000 |

**Total Estimated Effort:** 344h  
**Total Estimated Cost:** £31,000

###### Actions Required for Compliance

- [ ] Create and publish an official approved supplier list that includes each supplier’s legal entity identifier, risk level, and expiry date.
- [ ] Set up version-controlled, standard configuration baselines for the relevant types of acquisitions, and record any permitted exceptions (allowed deviations).
- [ ] Set up a procurement approval checkpoint in the enterprise resource planning (ERP) or procurement system that prevents orders from being placed with vendors that are not approved and blocks submissions where required baseline choices have not been selected.
- [ ] Add “policy-as-code” rules to require that maintenance and patch schedules are committed to, and that contracts include contingency and incident notification clauses.
- [ ] Set up the gate to record the purchase decision date, the order placement date, the expected delivery date, and the delivery route and provider.
- [ ] Set up an exception or waiver process with clear approval steps and an expiry date, and make sure every waiver reference is recorded and stored with the relevant purchase record.
- [ ] Store audit evidence for the baseline/version, waiver or exception identifiers, contract clause identifiers, and patch schedule commitments.


---

#### SR-3.3 — Sub-tier Flow Down (Enhancement)

This requirement is about making sure the same supply-chain expectations you set for your main suppliers are also written into the contracts those suppliers make with their own subcontractors, all the way down the supply chain. Without this, a risk could enter through a lower-tier supplier that does not meet the same standards for protecting your services and information. This could leave you exposed even if your top-level contracts appear to be compliant.

To meet this expectation, the organisation must:
- clearly identify which supply-chain risk and protection requirements it wants included;
- add a written obligation to each prime contractor contract requiring the prime contractor to include those exact requirements in every relevant subcontractor contract (including further sub-tiers);
- ensure the organisation’s procurement documents and templates clearly state this “flow-down” requirement.

The organisation must also involve the right people to define and check what must be passed down, keep acquisition records and service expectations consistent, and be able to provide evidence that both prime and subcontractor contracts actually include the required terms. Where any gaps are found, the organisation must follow them up until they are resolved.

##### Flow-down clause library and evidence annex for sub-tier contracts

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define the flow-down set mapping (SR-3b control areas → exact clause/annex references) and publish version-controlled mapping document | Compliance Manager | Enterprise | 24h | — |
| Draft the flow-down clause library (clause text + any annex templates) covering each mapped flow-down set item, including system/component/service acquisitions and associated SLAs/inter-organisational agreements | Security Engineer | Enterprise | 56h | — |
| Create the “Subcontractor Flow-Down Evidence Annex” template (award-time + change-triggered submissions) including required evidence types (clause excerpts/redacted copies, mapping checklist, sub-tier applicability confirmation) | Compliance Manager | Enterprise | 24h | — |
| Update prime contractor contract templates to include (a) mandatory flow-down obligation referencing the organisation’s clause library version and (b) sub-tier flow-down pass-through requirements | Project Manager | Enterprise | 32h | — |
| Configure procurement/contract lifecycle workflow controls to block approval unless the prime template includes the flow-down obligation and the evidence annex is present and correctly references the clause library version | Operations Lead | Enterprise | 40h | £3,000 |
| Establish verification and sign-off process (security/supply chain risk representatives) including RACI, sign-off checklist, and audit trail requirements per procurement | Cyber Security Lead | Enterprise | 24h | — |
| Pilot the approach with a small set of prime contracts, validate evidence completeness against the flow-down set, and refine templates/workflow based on findings | Service Delivery Manager | Business Unit | 24h | £2,500 |

Total Estimated Effort: **244h**  
Total Estimated Cost: **£5,500**

###### Actions Required for Compliance

- [ ] Identify the control areas for SR-3b that make up the required “flow-down” set, and document how each one maps to the relevant clause references.
- [ ] Create and maintain a library of clause-by-clause “flow-down” clauses, with version control and wording that is ready to use in contracts.
- [ ] Update the prime contractor contract templates to include a clear requirement to pass on (flow down) the required terms to subcontractors and, where applicable, to sub-tier subcontractors.
- [ ] Add a mandatory “Subcontractor Flow-Down Evidence Annex” that requires clause excerpts (or redacted copies) and a mapping checklist.
- [ ] Set up the procurement and contract lifecycle workflow so that approvals are only granted when the flow-down obligation clause and the evidence annex are included.
- [ ] Set up a review and approval process so that security and supply chain risk representatives check and sign off on the required “flow-down” terms and the clause library version for each procurement.


---

### SR-4 — Provenance (Control)

This requirement is about keeping a complete, reliable history for every on-premises system, software component, firmware, and approved starting configuration, and for any related Confidential and Secret information. The history must show where each item came from, who owned and controlled it, where it has been stored, and exactly what has changed over time. Without this, unauthorised or unexpected changes—such as those from suppliers, software or firmware updates, or internal mistakes—can go unnoticed. That makes it difficult to prove what happened, who was responsible, and whether the current setup is legitimate.

To meet this expectation, the organisation must clearly define which items are included, create a provenance record for each one, keep those records up to date as changes happen, and continuously monitor them for changes. It must also protect the provenance records from unauthorised edits, record who made any updates and the reason for them, and ensure the recorded history remains accurate and consistent— including when items are moved, ownership changes, or components are replaced.

##### Append-only provenance records for on-prem systems and data

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define authoritative provenance inventory model (stable IDs, scope boundaries, dataset classes for Confidential/Secret, mapping to CMDB/asset records) and publish governance rules | Compliance Manager | Enterprise | 24h | — |
| Design provenance baseline schema and event model (origin/ownership/location/config-baseline references, before/after linkage, actor identity model for human/workload) including cryptographic signing requirements | Security Architect | Enterprise | 32h | — |
| Implement append-only tamper-evident provenance store (WORM/immutable storage, retention policy, access controls, key management integration, signature verification workflow) | Platform Engineer | Enterprise | 56h | £18,000 |
| Build provenance event ingestion and normalisation pipelines (from change management, CI/CD, configuration management, release tooling; enrich with actor identity and change reference) | DevOps Lead | Enterprise | 72h | £12,000 |
| Implement reconciliation engine and mismatch alerting (expected vs observed deployed state; evidence bundle generation for audit; alert routing to SOC) | Operations Lead | Enterprise | 48h | £6,000 |
| Integrate audit-ready querying and reporting (chronology views, baseline-to-event traceability, export packs for SR-4 evidence; access logging for provenance writers/readers) | Compliance Manager | Enterprise | 40h | — |
| Run pilot on representative on-prem systems/data classes and execute control validation (test baselines, change events, signature verification, mismatch handling, operational runbooks) | Quality Assurance Lead | Business Unit | 32h | — |
| Operationalise: define authorised append/closure processes, exception handling, periodic access reviews, and training for provenance-relevant teams | Project Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 328h  
**Total Estimated Cost:** £36,000

###### Actions Required for Compliance

- [ ] Create an official inventory that gives each covered system, component, firmware, and configuration baseline a permanent (unchanging) ID, and also assigns a permanent ID to each associated Confidential or Secret dataset (or dataset type).
- [ ] Define and implement a standard “provenance” record format that captures: where data came from, who currently owns or has custody of it, where it is located and the environment it is in, which configuration baseline it is linked to, and references to any changes made.
- [ ] Create and store “provenance baselines” for all currently deployed covered items and datasets.
- [ ] Integrate the collection of change history (provenance) from change management, continuous integration and continuous delivery (CI/CD), and configuration management, so that every approved change generates a signed provenance event.
- [ ] Set up continuous checks to compare the expected source and history of data with what is actually deployed, and raise alerts when they do not match.
- [ ] Set up an append-only, tamper-evident record store that uses cryptographic signing and allows write access only for authorised roles.


---

#### SR-4.1 — Identity (Enhancement)

This requirement is about making sure the organisation can clearly identify everyone and everything involved in the supply chain behind its most important system parts, and keeping that information up to date. If the organisation cannot reliably identify all relevant suppliers, subcontractors, and system integrators, as well as the people and activities they carry out across research, building, delivery, installation, operation, maintenance, repair, and disposal, it becomes much harder to spot risky events and to understand what went wrong after a change, suspected wrongdoing, or an incident.

To meet this, the organisation must:
- define the full scope of what needs to be identified
- assign a single, unique reference to each organisation, process, and person involved
- record enough detail to support later investigation

It must keep these records in an auditable register, update them whenever the supply chain changes or an incident occurs, clearly assign responsibility for maintaining them, and ensure this approach is built into purchasing and supply-chain protection planning, with documented plans for the system.

##### Authoritative supply-chain unique ID register for critical components

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define in-scope boundaries per critical system component (supply-chain elements, processes/activities, and personnel) and map to sr-04.01_odp evidence expectations | Compliance Manager | Enterprise | 24h | — |
| Design authoritative register data model and governance rules (ElementID/ProcessID/PersonID, non-reuse, linkage to evidence, lifecycle status, effective dating, history retention) | System Design Authority | Enterprise | 32h | — |
| Implement controlled document/database approach (templates, fields, validation rules, access controls, versioning, audit trail requirements) aligned to the data model | Platform Engineer | Enterprise | 40h | £6,000 |
| Establish uniqueness and non-reuse enforcement (ID generation approach, deactivation rules, constraints, periodic reconciliation checks, exception handling) | Security Engineer | Enterprise | 24h | — |
| Integrate register updates into formal change workflows (supplier/integrator approval, contract amendments, key personnel changes, delivery/integration/disposal events) including required evidence capture | Project Manager | Enterprise | 32h | — |
| Create audit-ready evidence packs and operating procedures (how to produce investigation-ready lists per critical component; retention, access, and review cadence) | Compliance Manager | Enterprise | 24h | — |
| Pilot with one critical system component and remediate gaps (data completeness, evidence sufficiency, workflow integration, audit trail verification) | Service Delivery Manager | Business Unit | 24h | £2,500 |
| Train responsible owners and run initial assurance review (completeness checks, sampling, sign-off, and ongoing maintenance responsibilities) | Cyber Security Lead | Enterprise | 16h | — |

**Total Estimated Effort:** 216h  
**Total Estimated Cost:** £8,500

###### Actions Required for Compliance

- [ ] For each critical system component (per SR-04.01_ODP), define and document which supply-chain elements, processes, and people are included in scope.
- [ ] Design the official register data structure, including: Element ID, Process ID, Person ID, links to supporting evidence, lifecycle status, and effective dates.
- [ ] Create the register and give every supply-chain element, process, and person in scope a unique identifier that is never reused.
- [ ] Put in place governance to keep a complete history of records (Active or Inactive, with an Effective From date and an Effective To date) and to prevent identity numbers from being reused.
- [ ] Add updates to supplier, subcontractor, and integrator registers into the existing supply-chain change process, including changes to key personnel.
- [ ] Assign named ownership and make sure register updates have audit-ready access controls, version history, and retained evidence.


---

#### SR-4.2 — Track and Trace (Enhancement)

This requirement is about making sure every important item used to build, move, and install a product can be uniquely identified and tracked from start to finish. Without this, it is hard to prove where a specific hardware part, firmware update, or software build came from, whether it was changed while being transported, or which exact version was deployed. That makes it more difficult to limit the impact if something goes wrong and to investigate supply-chain problems after an incident.

To meet this expectation, the organisation must:
- clearly define which systems and critical components are included (in scope);
- assign a unique identifier to each item, and record the link between the identifier and the item;
- keep these identifiers accurate and unchanged as items move through development, transport, and deployment, while allowing more than one identifier when needed.

The organisation must also keep complete records of the full trail and ensure they are detailed enough to support investigations. This includes having clear ownership, documented processes, and the right requirements built into purchasing and planning documents.

##### Authoritative IDs and provenance records for in-scope artefacts

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define the in-scope item model for sr-04.02_odp (hardware units, firmware packages, software build artefacts) including “critical” sub-components and required identifier fields | System Design Authority | Enterprise | 24h | — |
| Design the authoritative identifier schema per item type (supporting multiple identifiers per item), including validation rules, uniqueness constraints, and mapping to existing asset/CMDB identifiers | Architect | Enterprise | 32h | — |
| Specify the provenance event model and data governance (event types, required attributes, ordering rules, exception handling, and audit evidence requirements) | Compliance Manager | Enterprise | 24h | — |
| Implement the governed provenance record store (data model, APIs, access controls, integrity protections such as append-only/signed events, and retention controls) | Platform Engineer | Enterprise | 56h | £18,000 |
| Integrate automated ingestion from CI/CD, artefact repository/container registry, release/configuration tooling, and warehouse scanning (build IDs, immutable digests, shipment/receipt events) | DevOps Lead | Enterprise | 72h | £6,000 |
| Enforce traceability at deployment time (deployment request validation, digest/hash match checks, missing mapping handling, and auditable exception workflow) | Security Engineer | Enterprise | 48h | — |
| Operationalise forensic readiness (audit logging to SIEM, evidence export/reporting, access reviews, and runbooks for incident/supply-chain compromise investigation) | Operations Lead | Enterprise | 32h | £4,000 |
| Pilot with representative in-scope artefacts and iterate to achieve acceptance criteria (end-to-end timeline completeness, multi-identifier mapping, deployment gating effectiveness) | Project Manager | Business Unit | 24h | — |

Total Estimated Effort: **312h**  
Total Estimated Cost: **£28,000**

###### Actions Required for Compliance

- [ ] Define what is included in scope for **sr-04.02_odp** (hardware, firmware, software build outputs, and critical sub-components) and document the rules for what must be included.
- [ ] Create and publish an identifier system for each item type that allows more than one identifier per item and ensures each identifier is unique and follows the required format.
- [ ] Set up a trusted provenance record store that connects each identifier to the relevant item and to the item’s supply-chain events (build, packaging, shipment, receipt, and deployment).
- [ ] Integrate continuous integration and continuous delivery (CI/CD) with artefact repositories and registries to automatically record build identifiers and unchangeable artefact hashes or digests in the provenance records.
- [ ] Integrate logistics and warehouse scanning (barcode and radio-frequency identification (RFID)) to record physical identifier scans and link shipment and receipt events to the same provenance records.
- [ ] Add a check at deployment time to ensure the recorded identifier mappings are present and that the artefact’s hash (digest) matches. Only then allow the deployment, or raise an auditable exception.
- [ ] Set how long provenance records are kept, who can access them, and add tamper-evident or integrity protections so they remain usable for forensic investigations.


---

#### SR-4.3 — Validate as Genuine and Not Altered (Enhancement)

This requirement is about making sure every computer part or software package you receive is genuinely from the correct supplier and has not been secretly altered. Without these checks, a counterfeit or tampered item could be installed, potentially giving criminals a hidden way to interfere with your systems, steal information, or disrupt services—sometimes without any obvious warning.

To meet this expectation, the organisation must set out and follow documented steps for acceptance testing before anything is used. This includes:
- obtaining and reviewing evidence from the supplier showing who handled the item and when
- checking that the software and firmware match the expected integrity checks (using mathematical verification)
- confirming hardware authenticity using tamper-evident measures, such as anti-tamper labels
- carrying out visual inspections and additional physical tests that can reveal signs of interference

The organisation must also:
- monitor for performance that is outside the stated specification
- treat any suspicious results as grounds to quarantine the item
- arrange replacement
- when needed, commission a forensic investigation to identify where the item came from

Finally, the organisation must keep records of all checks, include these validation expectations in purchasing documents and contracts, assign named responsibilities, and train relevant staff to recognise suspicious deliveries.

##### Acceptance gate for genuine, unaltered firmware/binaries

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define the acceptance validation procedure (evidence fields, pass/fail criteria, operator steps, quarantine/replace decision rule, retention requirements) | Compliance Manager | Enterprise | 24h | — |
| Establish the integrity trust model (vendor signing-key/certificate registry, certificate lifecycle/rotation process, supported algorithms, manifest/hash verification rules) | Cyber Security Lead | Enterprise | 32h | — |
| Implement automated integrity verification at receipt (extract artefacts, verify signatures and/or hashes, generate immutable acceptance evidence record with timestamps and identifiers) | Security Engineer | Department | 56h | £12,000 |
| Implement tamper-evidence and chain-of-custody validation workflow (seal/label ID capture, photo evidence, courier/supplier attestation ingestion, evidence linkage to asset/component) | Operations Lead | Business Unit | 40h | £6,000 |
| Integrate acceptance gate into CI/CD and release/deployment workflow (policy-as-code gate, block deployment on failed/missing evidence, environment-specific enforcement) | DevOps Lead | Department | 48h | £10,000 |
| Implement evidence storage, audit trail, and CMDB linkage (evidence schema, access controls, retention, audit export to SIEM/audit tooling) | Platform Engineer | Enterprise | 32h | £8,000 |
| Run pilot and operationalise (end-to-end test with representative firmware/binary types, tune thresholds, train operators, update runbooks and incident/forensics handover) | Project Manager | Business Unit | 24h | — |
| Total Estimated Effort |  |  | **256h** |  |
| Total Estimated Cost |  |  |  | **£36,000** |

###### Actions Required for Compliance

- [ ] Create an acceptance validation process that sets out the required proof, the rules for passing or failing, and the conditions that trigger quarantine.
- [ ] Maintain a trusted register of vendor signing keys and certificates, and a process to check that signed manifests (or expected file hashes) are valid.
- [ ] Set up an automated integrity check for received firmware and software files (preferably by verifying their digital signature; use file hashes as a backup) and store unchangeable proof of what was received.
- [ ] For every received component or image, require and review the supplier’s proof of chain of custody before you accept it.
- [ ] Carry out and record an inspection of the anti-tamper seal or label before setting up the service, including taking photos and recording the seal or label identification numbers.
- [ ] Add a continuous integration and continuous delivery (CI/CD) or release pipeline “gate” that prevents deployment unless the acceptance gate evidence shows the release was successful.
- [ ] Set up and run a process that isolates the affected item and escalates it for forensic investigation whenever any check fails.


---

#### SR-4.4 — Supply Chain Integrity — Pedigree (Enhancement)

This requirement is about making sure that the most important technology and services you buy are exactly what the supplier says they are—what they are made of and where they came from. Without this check, a harmful or changed item could be accepted, such as software that includes unexpected parts, hardware built from different components, or firmware that does not match the equipment delivered. This could lead to fraud, disruption, or a loss of trust in critical operations.

To meet this expectation, the organisation must first decide which items are critical or mission-essential. It must then require suppliers to provide proof of origin and make-up before anything is accepted. This includes records of the software parts and their versions, a list of components, manufacturer details such as serial numbers and hardware component lists, and unique identifiers that match the hardware actually delivered. The organisation must compare these records with what is being supplied, confirm the internal make-up and origin, use the results to accept or reject the item, and keep clear acquisition and planning records showing who checked what and when.

##### Pedigree acceptance gate for critical components and software

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create in-scope critical component/software catalogue and tier-to-evidence mapping (SKU/configuration, criticality tier, required pedigree artefacts per tier) | Compliance Manager | Enterprise | 24h | — |
| Define pedigree evidence schema and binding requirements (unit identifiers, SWID/SBOM fields, component versions, manufacturer declarations, hash algorithms/timestamps, evidence reference model) | Data Protection Officer | Enterprise | 20h | — |
| Standardise supplier requirements and acceptance gate updates (procurement templates, supplier onboarding checklist, receiving SOP, exception/disposition workflow) | Project Manager | Enterprise | 28h | — |
| Implement evidence intake and normalisation pipeline (parse/validate SWID/SBOM/manufacturer declarations; normalise identifiers; generate evidence set and audit references) | Software Lead | Enterprise | 56h | — |
| Build automated comparison against expected BoM for each SKU/configuration (mismatch rules: unexpected components, unauthorised versions, missing components, evidence not unit-bound) | Security Engineer | Enterprise | 48h | — |
| Implement hash verification and unit-binding enforcement (where artefacts are accessible: compute hashes for signed installers/images/firmware packages; where not, enforce unit-referenced supplier evidence) | Cyber Security Lead | Enterprise | 40h | £6,000 |
| Deploy audit logging and decisioning workflow (record pass/fail, evidence references, analysis outputs, approver for exceptions; integrate with existing ticketing/workflow) | Operations Lead | Enterprise | 24h | — |

Total Estimated Effort: **240h**  
Total Estimated Cost: **£6,000**

###### Actions Required for Compliance

- [ ] Create and get approval for an in-scope catalogue of critical, mission-essential items, including the required supporting evidence (“pedigree” artefacts) for each item type.
- [ ] Define a pedigree evidence format that requires unit identifiers (for example, serial numbers or platform identifiers) plus software identification (SWID) and software bill of materials (SBOM), including component version details and hash lists where applicable.
- [ ] Update the procurement and receiving templates so that pedigree evidence is a required acceptance document for all in-scope purchases.
- [ ] Set up an evidence intake and standardisation process to read and standardise software identification (SWID) component inventories, software bill of materials (SBOM) files, and manufacturer declarations.
- [ ] Set up automated checks to compare the supplier’s evidence against the expected bill of materials (BoM) for the specific stock keeping unit (SKU) and configuration, and highlight any differences.
- [ ] Verify the integrity of delivered items that can be accessed by checking their hash values, and reject the item if the hash evidence is not linked to the specific unit it was meant for.
- [ ] Record the validation results, link the supporting evidence, and document the accept or reject decision in an auditable workflow, with any exceptions automatically routed to supply chain risk management.


---

### SR-5 — Acquisition Strategies, Tools, and Methods (Control)

This requirement is about buying technology in a way that makes it much harder for harmful or unauthorised items to be supplied. If the organisation does not use trusted delivery routes, tamper-evident packaging, and restricted purchasing channels, a supplier could swap items, steal or alter components, or deliver counterfeit or contaminated parts. The organisation could also end up with products built using poor practices.

To meet this expectation, for every system, component, or service the organisation buys, it must:
- use trusted or controlled distribution;
- require tamper-evident packaging; and
- use restricted purchasing where applicable.

It must also put clear contract terms in place that:
- forbid counterfeit or tainted components; and
- require supply-chain transparency.

The organisation must have documented policies, procedures, and a plan for managing supply-chain risk during acquisitions. It must follow the documented acquisition process and steps that include these protection needs, include the requirements in invitations to tender and purchase records, and reflect them in service agreements where used. It must keep evidence that relevant staff have been trained, assign named responsibilities, and use supply-chain risk assessments to choose and tailor the buying approach to prevent, detect, and reduce these risks.

##### Risk-tiered procurement guardrails for trusted, tamper-evident supply

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define the supply chain risk tiering model for acquisitions (software/licences, managed services, critical spares, OT-adjacent components) including tier-to-SR-5 protection mapping aligned to `sr-05_odp` | Security Engineer | Enterprise | 40h | — |
| Produce SR-5 clause sets and contract template library (counterfeit/tainted prohibition; supply-chain transparency/provenance/traceability; subcontractor expectations for services) mapped to each tier | Compliance Manager | Enterprise | 32h | — |
| Configure procurement workflow policy-as-code guardrails in the ERP/procurement system (mandatory tier selection, required clause set selection, required fields for trusted/controlled distribution, tamper-evident packaging, and filtered-buy constraints where applicable) | Platform Engineer | Enterprise | 56h | — |
| Implement and validate approved supplier/distributor controls for trusted/controlled distribution and filtered-buy channel restrictions (including data model updates and integration with procurement system) | Infrastructure Lead | Enterprise | 24h | £8,000 |
| Build audit logging and evidence capture (requisition/PO/contract record fields, approver identity, timestamps, selected clause set, attached risk assessment evidence; reporting views for audit) | Operations Lead | Enterprise | 32h | — |
| Pilot the workflow with a representative set of categories (e.g., software/licences and managed services) and run control testing to confirm policy enforcement and audit evidence completeness | Quality Assurance Lead | Business Unit | 24h | — |
| Roll out governance and training (Procurement, Security approvers, Category Managers) plus operating procedures for exceptions and periodic review of tiering model and clause templates | Project Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 232h  
**Total Estimated Cost:** £8,000

###### Actions Required for Compliance

- [ ] Define a supply chain risk ranking model for acquisitions, and link each risk level (tier) to the required SR-5 protections from `sr-05_odp`.
- [ ] Set up a procurement workflow “policy as code” to allow only approved suppliers and distributors from a trusted, controlled list, based on their risk tier.
- [ ] Require tamper-evident packaging details on purchase orders and requests for proposals, and prevent approval when those details are missing for the applicable supplier tiers.
- [ ] Where relevant, apply filtered-buy constraints by limiting ordering channels or paths to approved routes.
- [ ] Update contract templates to include mandatory clauses that (1) prohibit tainted or counterfeit components and (2) require proof of supply-chain transparency.
- [ ] Add the results of supply chain risk assessments to purchase requisition records, and require supporting evidence to be attached for higher-risk supplier tiers.
- [ ] Assign named procurement and security approvers, and ensure audit logs record the selected tier, the clause set used, and the approval decisions.


---

#### SR-5.1 — Adequate Supply (Enhancement)

This requirement is about making sure the organisation can keep its industrial control equipment working even when deliveries are disrupted or parts fail. It matters because, if key items such as controllers, programmable logic controllers, safety relays, network switches, power supplies, or critical sensors and actuators cannot be obtained in time, operations could stop, safety could be compromised, and repairs could be delayed.

To meet this expectation, the organisation must keep an up-to-date list of which components are critical, decide what “enough supply” means for each one, and set clear targets for how much stock is needed and for how long during mission-critical periods. It must obtain these critical components from more than one supplier across the supply chain, keep spare parts available for the agreed mission-critical time periods, and identify functionally identical or similar substitute parts that can be used if the original item is not available, including the conditions for using them.

##### Adequate supply register with multi-sourcing, mission spares, and approved substitutes

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define scope: “critical system components” taxonomy, component classes (e.g., controllers/PLCs, safety relays, switches, power supplies, sensors/actuators), and governance ownership for updates | Compliance Manager | Enterprise | 16h | — |
| Design the auditable Critical Components Register data model (fields, compatibility constraints, criticality, mission-critical period definition, adequate-supply targets, multi-sourcing evidence, approved substitutes and limits) and publish register standard | Data Protection Officer | Enterprise | 24h | — |
| Implement/extend the register in the controlled repository (CMDB or GRC system): create templates, versioning, access controls, and evidence links for audit trail | Platform Engineer | Enterprise | 32h | — |
| Populate register for initial critical component set: capture identity, compatibility constraints, criticality, adequate supply targets (on-hand quantity + coverage duration), and mission-critical period basis | System Design Authority | Department | 48h | — |
| Establish multi-sourcing requirements and qualification workflow: define supplier qualification criteria, record at least two qualified sourcing routes per critical component, and retain contract/procurement evidence | Procurement Manager | Enterprise | 40h | £6,000 |
| Define and implement mission-critical spares policy: set minimum on-hand quantities and reorder points per component, storage/handling rules, and periodic verification cadence (fit-for-use checks) | Operations Lead | Department | 32h | — |
| Document approved substitutes: identify functionally identical/similar alternates, define substitution conditions/limits (electrical/firmware/safety certification/configuration), and specify required engineering validation evidence | Security Engineer | Department | 40h | — |
| Integrate into procurement and change workflows: update requisition/contract templates and acceptance checks to reference register entries, spares targets, selected suppliers, and substitution rules; provide audit-ready evidence mapping | Project Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 304h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Create and keep a **Critical Components Register** that lists every item in **sr-05.01_odp.02**, including its level of criticality, any compatibility limits, and the approved alternative options.
- [ ] Set measurable “adequate supply” targets for each critical component, including how long mission-critical coverage must last and the reason (basis) for each target.
- [ ] For each critical component in the register, identify and record multiple approved suppliers and sourcing routes across the supply chain.
- [ ] Set and manage the stock levels for mission-critical spare parts (minimum quantities on hand and reorder points), and carry out regular checks to confirm the parts are still fit for use, keeping evidence of these checks.
- [ ] Document any functionally identical or similar substitute products or components, and clearly state the conditions and limits under which substitutions are allowed (including any required engineering validation).
- [ ] Update the procurement and contracting templates, and the purchase requisition templates, to refer to the register entries, spare parts targets, supplier selections, and substitution rules.


---

#### SR-5.2 — Assessments Prior to Selection, Acceptance, Modification, or Update (Enhancement)

This expectation is about making sure that anything new you bring into your organisation—software, hardware, services, or updates—is checked first, before you commit to it. It addresses the real-world risk that a supplier item or change could be altered, include harmful hidden behaviour, be faulty, or be a fake product, and that weaknesses could be missed. If that happens, it could lead to disruption, loss of data, or unauthorised access.

To meet this requirement, the organisation must carry out suitable security checks and inspections before choosing, accepting, changing, or updating the item. The checks should be appropriate to what it is, and should specifically look for signs of tampering, malicious behaviour, hidden access paths, unintentional or deliberate weaknesses, faulty or counterfeit items, and any failure to follow supply-chain protection expectations.

The organisation must record the results and keep the evidence so that decisions and follow-up actions can be taken. It must also ensure the right internal roles (and independent external assessors where needed) carry out the work and document it.

##### Security assessment gate for app/service selection and updates

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define security assessment gate workflow requirements (item categories, risk tiers, required methods, go/no-go outcomes, evidence completeness rules) and publish as an enterprise standard | Compliance Manager | Enterprise | 24h | — |
| Build assessment catalogue and evidence package schema (required fields, validation rules, decision record linkage, residual risk format) | Security Engineering / AppSec | Enterprise | 32h | — |
| Integrate hard workflow gates into existing procurement/release/change tooling (e.g., enforce “evidence attached + validated” before selection award, acceptance sign-off, change approval, and deployment) | Platform Engineer | Enterprise | 48h | — |
| Implement automated evidence capture for software artefacts and container images (signature/provenance verification, SBOM ingestion, SAST/dependency scanning, image scanning; persist outputs to evidence store) | DevOps Lead | Enterprise | 56h | £18,000 |
| Implement automated evidence capture for web/API changes (controlled DAST execution, targeted authz/authn regression, fuzz testing where applicable; record results and timestamps) | Security Engineer | Enterprise | 40h | £12,000 |
| Establish independent assessment support process (criteria for when external/internal assessor is required, report template, linkage to decision record, audit sampling approach) | Compliance Manager | Enterprise | 20h | — |
| Operationalise audit readiness (evidence retention schedule, audit sampling controls, monitoring/alerting for gate bypass attempts, runbooks, and training for CAB/Release Managers and Change Owners) | Operations Lead | Enterprise | 28h | — |

**Total Estimated Effort:** 288h  
**Total Estimated Cost:** £30,000

###### Actions Required for Compliance

- [ ] Create an assessment catalogue that links each item category to the required assessment method and the evidence documents or records needed.
- [ ] Set up procurement, release, and change workflows with mandatory “hard stops” that prevent selecting, accepting, implementing, or updating anything until the required evidence is provided.
- [ ] Set up automated evidence collection to prove where software artefacts came from (for example, signatures and checksums), bring in software bill of materials (SBOM) information, run static application security testing (SAST) and dependency scanning, and scan container images for known security issues.
- [ ] For any applicable changes to web applications or application programming interfaces (APIs), run controlled dynamic tests and targeted fuzzing and authorisation (authz) regression tests, and record the results in the evidence package.
- [ ] Create a standard evidence pack template with the required sections: scope, methods, results, remaining (residual) risk, decision outcome, and dates and times (timestamps).
- [ ] Require independent assessment report uploads for items or services where the risk level or procurement model requires external verification, and link each report to the decision record.
- [ ] Run a pilot release to test the gate, and carry out an audit sampling exercise to confirm that the required evidence is produced and approved before deployment or acceptance.


---

### SR-6 — Supplier Assessments and Reviews (Control)

This requirement is about making sure every supplier or contractor you rely on is properly checked for supply-chain and information risks—not just once, but regularly and whenever something changes. Without these checks, a supplier could introduce weaknesses, mishandle sensitive information, fail to manage risks in its own subcontractors, or even supply counterfeit or compromised parts. Any of these could then harm your services and your customers.

To meet this expectation, the organisation must assess and review the risks connected to each in-scope supplier and the system, component, or service they provide at least every year, and also whenever there is a major supplier change or a security incident. These reviews must follow documented methods and plans. They must include checks for foreign ownership, control, or influence, and confirm that the supplier can also assess its own lower-tier suppliers and contractors.

The organisation must use documented procedures and evidence, any relevant intelligence available, and information that is publicly available. The reviews must be carried out either by the organisation itself or by an independent third party. The organisation must keep clear records and link the review outcomes to the relevant system and procurement documentation.

##### Automated supplier risk review workflow with FOCI and tiered assurance

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Design the in-scope supplier register data model (supplier ↔ system/component/service mapping, data/access impact, risk tier attributes, ownership fields, contract linkage keys) | System Design Authority | Enterprise | 24h | — |
| Define SR-6 risk tiers, significant-change triggers, and security-incident triggers; produce documented decision logic and tier-to-evidence requirements (including FOCI and 2nd/3rd-tier assurance capability) | Compliance Manager | Enterprise | 32h | — |
| Build the SR-6 review workflow (annual cadence + trigger-based re-runs) with workflow states, required fields per tier, assessor/approver roles, and escalation paths | Software Lead | Enterprise | 80h | — |
| Implement the evidence-based review template (workflow form) with structured evidence capture for: security/supply-chain controls, FOCI screening results, 2nd/3rd-tier assurance evidence, indicators (stolen info/poor QC/spillage/counterfeits) with “sources consulted” references, and independent third-party report attachment | Security Engineer | Enterprise | 56h | — |
| Configure auditable enforcement controls (block onboarding/renewal closure until SR-6 required fields are complete for the supplier’s tier; ensure each review record links to system security documentation and procurement/contract file) | Operations Lead | Enterprise | 48h | — |
| Integrate controlled “sources consulted” mechanism (threat intel/vulnerability advisories/sanctions/ownership/public reporting) and store references used for each review; implement assessor guidance for consistent evidence | Cyber Security Lead | Enterprise | 64h | £18,000 |
| Implement sharing rules and audit logging (record legal/contractual basis for sharing; ensure least-privilege access to review outputs; retain immutable audit trail) | Data Protection Officer | Enterprise | 40h | — |
| Test, pilot, and roll out (end-to-end workflow testing, evidence completeness validation, procurement/security UAT, training, and go-live for in-scope supplier cohorts) | Project Manager | Enterprise | 48h | £6,000 |

**Total Estimated Effort:** 392h  
**Total Estimated Cost:** £24,000

###### Actions Required for Compliance

- [ ] Create and keep up to date an in-scope supplier register that lists each supplier and the specific system or service they provide.
- [ ] Define supplier risk categories and set up workflow triggers for an annual review, any major supplier change, and a security incident.
- [ ] Create an “SR-6” review template that requires documented evidence showing how security and supply-chain risk are managed, how foreign ownership, control, or influence (FOCI) is addressed, and that lower-tier suppliers have the capability to provide assurance.
- [ ] Add a controlled record of every “source consulted” to show what information was used in each review, including both intelligence from all sources and publicly available information.
- [ ] Require workflow approval gates so procurement onboarding or renewal cannot be completed unless the supplier’s risk tier has had the SR-6 review completed.
- [ ] Store the results of each review in an auditable record system, and link every record to the relevant system security documentation and the related procurement or contract file.


---

#### SR-6.1 — Testing and Analysis (Enhancement)

This requirement is about checking, before and while software and firmware are being built and updated, that the people and tools involved—and any external partners who help integrate the software—are operating in a trustworthy way. If this is not done, a hidden flaw, an unauthorised change, or a risky practice could enter during development, through the change-tracking tools, or via a third-party integrator, and later lead to service disruption, data loss, or financial harm.

To meet this requirement, the organisation must:
- carry out its own analysis and testing, and also
- arrange independent testing by an external party

This must cover:
- the software and firmware development processes
- the configuration management tools used to track and control changes
- the third-party integrators

The organisation must also:
- define what will be tested and how it will be tested
- assign clear responsibility for the work
- keep an up-to-date list of the supply-chain parts that are covered
- maintain the relevant plans and procedures

Finally, it must document the testing results and use them to inform supply-chain risk decisions.

##### Dual internal + independent testing for supply-chain elements

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Establish and maintain the “supply-chain assurance package” workflow (intake, evidence requirements, approvals, audit trail) mapped to sr-06.01_odp.02 | Compliance Manager | Enterprise | 24h | — |
| Create the in-scope supply-chain register template and governance (software/firmware dev processes, configuration management tool owners, third-party integrators) with explicit mapping to sr-06.01_odp.02 | Project Manager | Enterprise | 16h | — |
| Define the standard dual-testing test matrix and evidence checklist per category (secure SDLC evidence, configuration management provenance/change-control evidence, integrator integration/release packaging evidence) | Security Engineer | Enterprise | 32h | — |
| Implement internal (organisational) testing/analysis procedures for each release/major change (evidence pack collection, targeted validation steps, sufficiency checks, and documented outcomes) | Operations Lead | Enterprise | 40h | — |
| Commission independent third-party testing for each release/major change (procurement enablement, SOW templates, acceptance criteria for reports, evidence handover requirements) | Procurement / Vendor management | Enterprise | 24h | £18,000 |
| Build the auditable assurance package repository and release/change traceability (document storage, naming conventions, retention, linkage to risk decisions and approvals) | Platform Engineer | Enterprise | 24h | £6,000 |
| Operationalise governance and run the first end-to-end pilot (execute dual testing for a representative release, present findings to SCRM risk decision forum, record accept/mitigate/retest triggers, lessons learned) | Supply Chain Risk Manager | Enterprise | 40h | — |

**Total Estimated Effort:** 200h  
**Total Estimated Cost:** £24,000

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date supply-chain register that maps each system or service to the categories in **sr-06.01_odp.02**.
- [ ] Create a test plan that covers both software and firmware development, the configuration management tools used to control settings, and the third-party partners who integrate with the system.
- [ ] Set up an assurance process that requires internal testing and analysis evidence for every release or major change.
- [ ] Contractually require independent third-party testing and analysis for the same in-scope categories, and require auditable evidence records as outputs.
- [ ] Put in place an approval step (gate) so that supply-chain risk decisions are updated using documented results from both internal reviews and independent assessments.
- [ ] Store all evidence in a repository that can be audited and is linked to each software release, and keep it for compliance review.


---

### SR-7 — Supply Chain Operations Security (Control)

This requirement is about preventing sensitive information—such as what you buy, how you use it, and who it is for—from being leaked through your suppliers. Without these protections, a determined outsider could use clues from normal purchasing and delivery activity, supplier documents, and shared technical information to work out who uses your services, what they do with them, and how your systems are built. This could give them a head start to cause disruption or harm.

To meet this expectation, the organisation must first identify the most critical supply-chain information (including details about users and use, supplier identities and processes, and design and testing results). It must then assess what suppliers and others could realistically see and infer. The organisation must agree safeguards with suppliers through procurement documents and contracts, check that the risk is reduced to an acceptable level, and consider how combining several small pieces of information could increase overall exposure.

Where needed, the organisation must limit or withhold sensitive details and use intermediaries so suppliers cannot easily learn the final use or the final users.

##### Supply-chain OPSEC inference analysis and critical info classification

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Establish supply-chain OPSEC methodology and templates (scope per procurement item, critical info register schema, inference/aggregation worksheet, supplier sharing rule template, evidence checklist) | Compliance Manager | Enterprise | 24h | — |
| Define supply-chain OPSEC scope per procurement item (identify in-scope information types for each system/component/service, including SaaS/managed services/integrations; confirm system owners provide accurate inputs) | Cyber Security Lead | Enterprise | 32h | — |
| Create and populate the “critical supply-chain information” register (map each information type to sensitivity level and explicit protection requirement: share/redact/withhold/secure intermediary) | Data Protection Officer | Enterprise | 24h | — |
| Run adversary inference workshops per procurement item (document observable indicators from procurement/communications/onboarding/docs/configuration granularity; record plausible adversary inferences and potential harm) | Security Engineer | Enterprise | 40h | — |
| Perform aggregation exposure analysis (identify multi-source/timeline/tenant/region combinations that could reveal end users/uses or sensitive configurations; define aggregation thresholds and risk rationale) | Threat intelligence / Security engineering | Enterprise | 32h | — |
| Translate outcomes into enforceable supplier-facing sharing rules (field-level redaction guidance, secure transfer/handling instructions, intermediary requirements, and explicit restrictions on end-use/end-user details) | Procurement category manager + Supplier management | Enterprise | 24h | — |
| Generate audit-ready evidence and governance linkage (central repository entries per procurement item; version control, approvals, retrievability for audit; maintain evidence retention mapping) | Project Manager | Enterprise | 20h | — |

Total Estimated Effort: **196h**  
Total Estimated Cost: **£0**

###### Actions Required for Compliance

- [ ] Create a supply-chain operational security (OPSEC) scope template that covers: who will use the system and how they will use it, the identities and processes of suppliers, the system configurations, the design requirements, and the results of any testing and evaluation.
- [ ] Maintain a critical supply-chain information register that records the sensitivity level of each item and sets clear rules for how each type of information must be protected and handled.
- [ ] Run adversary inference workshops to record what can be observed from friendly actions and the most likely ways an attacker could interpret those actions.
- [ ] Carry out an analysis of how data is combined to find combinations that could reveal who uses the system, what they use it for, or sensitive configuration details.
- [ ] Publish approved rules for suppliers on what to share, redact, or withhold, and the secure handling instructions for each procurement item.
- [ ] Store audit-ready evidence that links the operational security (OPSEC) scope, the inference and aggregation results, and the resulting sharing rules to each system, component, and service procured.


---

### SR-8 — Notification Agreements (Control)

This requirement is about making sure your suppliers and other partners tell you quickly if they find a problem in their products or services that could harm your systems, or if they suspect one. If there are no clear, agreed rules for notification, a serious supply-chain problem could go unnoticed for too long, leaving you unable to respond, protect customers, or reduce the damage.

To meet this expectation, the organisation must:
- identify all supply-chain partners involved in providing the system, key components, or services; and
- put written agreements in place that clearly state what must be reported, what information to include, when to notify you, and how to contact you (including named points of contact and approved communication channels).

These agreements must also cover sharing relevant assessment or audit results, including useful information from public sources, so partners can fix the issue and improve their processes.

The organisation must record these requirements in procurement and contract documents, ensure service agreements include the same notification expectations, assign named responsibilities internally, and document the approach in the system security plan or related records.

##### Enforceable supplier compromise notification clauses and onboarding

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define SR-8 supply-chain compromise notification requirements: scope (confirmed + potential), severity tiers, time-to-notify targets, required notification content, and mapping to sr-08_odp.01 and sr-08_odp.02 | Cyber Security Lead | Enterprise | 16h | — |
| Draft standard contract schedule/SLA addendum “Supply-chain Compromise Notification” (including approved notification methods, named points of contact, mandatory sharing of relevant assessment/audit results and relevant public-source information, and enforceability/termination/flow-down wording where applicable) | Legal/Commercial Counsel | Enterprise | 24h | — |
| Review and approve clause wording through internal governance (procurement, security, legal sign-off) and produce final controlled template pack (contract schedule, guidance notes, and clause versioning identifiers) | Compliance Manager | Enterprise | 12h | — |
| Implement procurement gate: update procurement workflow/templates so no material supplier contract/SLA is signed without the SR-8 schedule being attached and accepted; include evidence capture requirements | Project Manager | Enterprise | 20h | — |
| Identify, tier, and validate material supply-chain partners for the application context; produce initial supplier list with system/component/service mapping and determine which contracts require the SR-8 schedule | Application Owner / Service Owner | Business Unit | 18h | — |
| Run supplier onboarding confirmation (security + procurement): collect current notification contacts/channels/escalation paths, confirm clause acceptance, and record mapping to the application/system security plan section for supply-chain communications | Operations Lead | Business Unit | 24h | — |
| Establish and maintain auditable supplier register (supplier entity → contract/SLA ID → scope → clause version → named contacts → storage location of signed agreements) and ensure controlled retention of evidence for audit | Data Protection Officer | Enterprise | 20h | — |

| Total Estimated Effort |  |  | **134h** |  |
| Total Estimated Cost |  |  |  | **£0** |

###### Actions Required for Compliance

- [ ] Create a register of material suppliers for the application’s system components and services, including contract reference numbers and named contacts for security notifications.
- [ ] Draft a standard contract schedule for “supply-chain compromise notifications” that covers confirmed and possible compromises, the required information, when notifications must be sent, and the approved ways to send them.
- [ ] Add mandatory clauses requiring the supplier to share relevant assessment and audit results (sr-08_odp.02) and any relevant information from public sources, where that information was used to inform the supplier’s assessment or decision.
- [ ] Require a procurement approval step so that no material supplier contract or service level agreement (SLA) is signed unless the SR-8 notification schedule is attached and has been accepted.
- [ ] Complete supplier onboarding to confirm the named points of contact, the escalation route, and the notification channels, and store the supporting evidence in the controlled repository.
- [ ] Update the application or system security plan (or the linked record) to reference the SR-8 notification procedure and the official supplier register.


---

### SR-9 — Tamper Resistance and Detection (Control)

This requirement is about making sure important systems, parts, or services are difficult to secretly change, and that any unauthorised tampering can be detected quickly. Without this, someone could replace a genuine component with a modified or counterfeit one, or change how software or a service behaves during delivery or while it is in use. This could lead to fraud, disruption, or the exposure of sensitive information.

To meet this expectation, the organisation must set up and maintain a tamper protection programme for the items in scope. The programme must clearly state what is covered, who is responsible, and the written steps for both preventing unauthorised changes and detecting them during delivery and during normal operation. It must also document the tools and methods used, keep the programme and related records up to date, and ensure the same tamper protection expectations are included in purchasing decisions, supplier contracts, and service agreements. The organisation must also keep evidence that suppliers are assessed against these requirements.

##### Tamper protection programme using signed artefacts and delivery checks

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define tamper protection scope and tamper surfaces (in-scope artefacts, threat definition, baseline items, verification failure criteria) | Compliance Manager | Enterprise | 16h | — |
| Produce tamper protection programme document (delivery/receiving checks, in-use integrity/drift checks, escalation/response, evidence retention requirements) | Compliance Manager | Enterprise | 24h | — |
| Design and implement signed artefact build/release controls (signing strategy, key management integration approach, provenance capture, release pipeline enforcement) | DevOps Lead | Business Unit | 56h | £6,000 |
| Configure deployment admission gates to accept only valid signatures/provenance (orchestration/tooling integration, rollback behaviour, exception handling workflow) | Platform Engineer | Business Unit | 40h | £3,000 |
| Implement delivery/receiving verification (automated/manual receiving checklist, signature/checksum validation, evidence capture, environment promotion rules) | Operations Lead | Department | 24h | — |
| Implement in-use integrity verification and drift detection (scheduled/event-driven checks, baseline management, alerting rules, SIEM integration, runbooks) | Security Engineer | Department | 48h | £8,000 |
| Update acquisition and service agreements (procurement templates/SLAs, supplier evidence requirements, contractual audit trail retention) | Data Protection Officer | Enterprise | 20h | — |
| Establish audit-ready evidence management and programme governance (log retention mapping, periodic reviews, control effectiveness testing, corrective action tracking) | Project Manager | Enterprise | 24h | — |

Total Estimated Effort: **252h**  
Total Estimated Cost: **£17,000**

###### Actions Required for Compliance

- [ ] Define and document the scope of SR-9 (the systems, components, and services included) and the tamper points and items (artefacts) that must be protected.
- [ ] Create the tamper protection section, including: delivery and receiving verification, integrity checks while the system is in use, and the procedures to follow if tampering is detected.
- [ ] Add cryptographic signing to release files (for example, container images, software packages, and deployment manifests) as part of the continuous integration and continuous delivery (CI/CD) pipeline.
- [ ] Set up deployment admission controls to block any software packages that are not signed or cannot be verified, and record whether each package was admitted and whether its verification succeeded or failed.
- [ ] Set up receiving gates that verify supplier and internal signatures and checksums before any files are accepted into any environment.
- [ ] Set up runtime (in-use) integrity and change-drift monitoring against an approved baseline, and send any detected failures to the security information and event management (SIEM) system for alerting.
- [ ] Update acquisition templates and service level agreements (SLAs) to require signed and verifiable deliverables, and to keep records showing the supplier’s compliance and the checks performed to verify it.


---

#### SR-9.1 — Multiple Stages of System Development Life Cycle (Enhancement)

This requirement is about ensuring systems are designed, built, and managed in a way that makes unauthorised interference difficult and that can detect it quickly. This must be done from the earliest planning stage through to disposal. Without this, someone could tamper with hardware or software during development, delivery, or everyday use, or replace items with altered versions through suppliers. This could create hidden faults, enable fraud, or cause service disruption that may be difficult to spot.

To meet the expectation, the organisation must set out its approach to preventing and detecting tampering in its development and acquisition records, and apply it at every stage of the system’s life cycle. This includes research and design, manufacturing, purchasing, delivery, integration, operations and maintenance, and disposal. It must document the specific procedures for resisting tampering and detecting it, the tools and methods used, and how protection is handled across the supply chain. These expectations must also be included in procurement policies, contracts, and service agreements.

Finally, the organisation must clearly assign responsibilities to the appropriate roles and keep evidence showing the measures were actually applied and can be followed in practice.

##### SDLC stage-gates for anti-tamper resistance and detection evidence

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create anti-tamper control catalogue (Resistance + Detection) with tool/technique approvals and evidence requirements per control | Cyber Security Lead | Enterprise | 24h | — |
| Define SDLC stage-gates and update SDLC templates (R&D, design, build/manufacture, acquisition/delivery, integration, operations/maintenance, disposal) with mandatory resistance + detection expectations and gate exit criteria | Compliance Manager | Enterprise | 32h | — |
| Embed verifiable acceptance criteria into engineering artefacts (threat modelling tamper scenarios, design requirements for self-check points, build/provenance/SBOM requirements, receipt integrity checks, runtime escalation triggers, disposal wipe/destruction evidence) | Security Engineer | Enterprise | 28h | — |
| Implement evidence automation in CI/CD and delivery pipelines (signed artefacts, provenance attestation, SBOM generation, immutable evidence capture linked to system record/release) | DevOps Lead | Enterprise | 56h | £18,000 |
| Implement detection-as-code for operational self-checking/integrity verification (version-controlled logic, peer review workflow, tamper-indicator logging, alerting hooks to SIEM) | Platform Engineer | Enterprise | 48h | £6,000 |
| Establish auditable evidence repository and retention/immutability controls (evidence schema, access controls, linkage to releases and tickets, audit export capability) | Operations Lead | Enterprise | 24h | £4,000 |
| Run pilot for a representative release and perform evidence trail validation (gap analysis, remediation, sign-off against stage-gates and SR-9(1) expectations) | Project Manager | Business Unit | 20h | — |
| Maintain the single “anti-tamper programme” document and governance cadence (responsibilities, approved techniques, evidence locations, change control, periodic review) | Compliance Manager | Enterprise | 12h | — |

Total Estimated Effort: **244h**  
Total Estimated Cost: **£28,000**

###### Actions Required for Compliance

- [ ] Create an anti-tampering control catalogue that lists both resistance measures and detection methods suitable for the application stack.
- [ ] Update the software development life cycle (SDLC) stage-gate templates so that each SDLC stage includes requirements for anti-tampering protection and agreed acceptance criteria for detecting tampering.
- [ ] Set up continuous integration and continuous delivery (CI/CD) to produce signed release files, provenance records, and software bills of materials (SBOMs), and to store the supporting evidence in an unchangeable way for each release.
- [ ] Carry out delivery and integration integrity checks that block unsigned or unauthorised software components, and record the results of each check.
- [ ] Set up ongoing checks to confirm the software is still intact while it is running, with alerts if tampering is suspected, and with documented steps for how to escalate and respond.
- [ ] Define and provide evidence for secure disposal or decommissioning steps for keys, artefacts, and components, linked to the system record.


---

### SR-10 — Inspection of Systems or Components (Control)

This requirement is about making sure the physical parts and built-in components of your on-site equipment have not been secretly changed before they are trusted and used. Without regular checks, someone could tamper with the hardware or its built-in software so that it behaves differently, which could allow attackers to intercept data, disrupt services, or get around safeguards.

To meet this expectation, the organisation must:
- define which on-site equipment and built-in components are covered by these checks,  
- select a sample at random, and  
- inspect that sample at least once every quarter for signs of tampering.

Inspections must cover both:
- **physical tampering**, such as signs the equipment has been opened or altered seals/labels, and  
- **logical tampering**, such as unexpected built-in software or changes to settings.

Any component that has been removed from controlled areas must be inspected before it is returned to use. Additional inspections are required if packaging, specifications, factory location, or supplier identity changes, or when staff return from travel to high-risk locations.

Named staff must carry out the checks, keep records and reports of what was inspected, what was found, and any follow-up actions.

##### Quarterly random tamper inspections for in-scope on-prem hardware

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define the in-scope inspection scope list (sr-10_odp.01): identify component types, minimum required identifiers (asset tag/serial), and required baseline references (firmware/software/config) | Compliance Manager | Enterprise | 24h | — |
| Establish inspection trigger criteria and workflow mapping (sr-10_odp.04): define “indications of need”, travel-to-high-risk handling, and “removed from organisation-controlled areas” before re-use | Security Engineer | Enterprise | 20h | — |
| Design the auditable random selection method (sr-10_odp.02) with repeatability: sampling frequency at least quarterly (sr-10_odp.03), selection algorithm/seed approach, and required selection evidence fields | Cyber Security Lead | Enterprise | 28h | — |
| Implement operational checklists and evidence capture standards for physical + logical tampering (sr-10_odp.01): standard forms, photo requirements, pass/fail criteria, and escalation/quarantine actions | Security Operations Lead | Enterprise | 32h | — |
| Configure GRC/ticketing or CMDB-linked workflow to store inspection evidence and link to asset IDs: selection evidence, checklist results, firmware/config values, photos, and follow-up actions | Platform Engineer | Enterprise | 40h | £3,000 |
| Pilot the programme for one quarter: run one full random sample cycle plus at least one out-of-cycle trigger test; remediate gaps and update procedures | Project Manager | Enterprise | 24h | — |
| Deliver training and authorisation for inspection technicians/engineers: role-based sign-off, how to perform checks, how to record evidence, and how to handle exceptions | Service Delivery Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 184h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Create and keep an accurate master list (inventory) of all on-premises systems and components that are in scope, giving each one a unique identifier and recording whether it is located in a controlled area.
- [ ] Define standard physical and logical tamper-check checklists, aligned to the expected firmware, software, and configuration baseline settings.
- [ ] Carry out a documented quarterly random selection from the inventory snapshot and keep evidence showing how the selections were made.
- [ ] Carry out physical and digital checks for signs of tampering on each randomly selected asset, and record the results against the asset’s ID.
- [ ] Carry out inspections outside the normal schedule before re-use if components leave or return from areas controlled by the organisation, or if an “sr-10_odp.04” indication is detected.
- [ ] Store inspection records—selection evidence, findings, photos, firmware and configuration values, and follow-up actions—in an auditable system with defined retention periods.


---

### SR-11 — Component Authenticity (Control)

This requirement is about making sure that any parts you buy and use in your systems are genuine, not fake lookalikes. If counterfeit parts get into your systems, they can fail early or be deliberately changed to cause harmful behaviour, putting your organisation’s operations and data at risk.

To meet this expectation, the organisation must create an anti-counterfeit policy, get it formally approved, and apply it across purchasing and receiving activities. This includes parts sourced from manufacturers, developers, vendors, and contractors.

The organisation must also create and follow clear procedures that tell staff how to spot suspicious parts before they are accepted, how to prevent them from entering or being used if there is a concern, and what immediate actions to take. If counterfeit parts are identified, staff must promptly report them to the system security officer and the supply chain risk management lead, and, where appropriate, also report them to the Cybersecurity and Infrastructure Security Agency (CISA).

##### Anti-counterfeit procurement receiving gate with CISA reporting

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Draft anti-counterfeit policy (SR-11 aligned) including scope across manufacturers/developers/vendors/contractors, detection/prevention expectations, quarantine/hold rules, internal recipients, and CISA external reporting decision path | Compliance Manager | Enterprise | 16h | — |
| Review, legal/commercial alignment, and formal approval of anti-counterfeit policy with version control and publication to the organisation policy repository | Compliance Manager | Enterprise | 12h | — |
| Create anti-counterfeit receiving/procurement procedures (step-by-step) covering evidence artefacts, risk-based validation checks, stop/hold actions, exception handling, and audit evidence requirements | Supply chain risk management lead | Enterprise | 20h | — |
| Configure receiving gate workflow controls in procurement/CMDB/asset intake: mandatory evidence fields, supplier/category allow-list enforcement, identifier consistency checks (PO/packing list/COC), and block installation/acceptance when evidence is missing/inconsistent | Platform Engineer | Enterprise | 48h | £3,000 |
| Implement quarantine/hold and exception handling workflow: automatic hold status, routing to System Security Officer and Supply Chain Risk Management Lead, and controlled release only via approved exception | DevOps Lead | Enterprise | 32h | £2,500 |
| Build auditable incident/supply-chain ticket template and decision record for suspected/certain counterfeit findings, including required data capture and explicit “CISA reported vs not reported” justification fields | Security Engineer | Enterprise | 24h | — |
| Integrate workflow outputs with logging/SIEM and ensure audit-ready evidence retention (ticket history, decision record, evidence artefacts references) plus runbook for periodic access/review | Operations Lead | Enterprise | 20h | £1,500 |
| Deliver training and operational readiness for procurement/receiving and relevant engineering/asset intake teams; include tabletop exercise for suspected counterfeit scenario and confirm effectiveness of the receiving gate | Project Manager | Business Unit | 16h | — |

**Total Estimated Effort:** 208h  
**Total Estimated Cost:** £7,000

###### Actions Required for Compliance

- [ ] Draft and obtain formal approval for an anti-counterfeiting policy covering manufacturers, developers, vendors, and contractors.
- [ ] Publish anti-counterfeit receiving and procurement procedures, including practical steps for detecting counterfeit goods and clear “hold” and “stop” actions.
- [ ] Set up the procurement and goods-receiving process so that acceptance cannot happen until required traceability evidence is provided, including part, serial number, and lot number, the certificate of conformity (COC) type, and a chain-of-custody reference.
- [ ] Carry out checks to confirm the evidence matches across the purchase order, packing list, and certificate identifiers, and stop the installation if any check fails.
- [ ] Create a “quarantine/hold” status in the asset and configuration management database (CMDB) intake process that blocks installation until the security and supply-chain review is complete.
- [ ] Set up automated ticketing and escalation to the system security officer and the supply chain risk management lead for any suspected or confirmed counterfeit finding.
- [ ] Set up and enforce a decision log that can be audited for external reporting to the Cybersecurity and Infrastructure Security Agency (CISA), showing whether each item was reported or not reported, with the reason for any decision not to report.


---

#### SR-11.1 — Anti-counterfeit Training (Enhancement)

This requirement is about making sure the right people in your organisation can identify fake or copied parts and software before they are added to your systems. Without this training, counterfeit hardware, software, or firmware could be introduced through suppliers. This can lead to unreliable performance, hidden weaknesses, fraud, or disruption that is difficult and expensive to fix later.

To meet this expectation, the organisation must train supply chain security officers, hardware and firmware engineers, software developers, and system administrators to recognise counterfeit components and to take clear steps to stop them entering the organisation’s systems. The training materials must specifically cover how to detect and prevent counterfeit hardware, software, and firmware. Staff must also be taught what to do if something looks suspicious, in line with the organisation’s anti-counterfeit policies and procedures.

The organisation must keep retrievable records showing who completed the training and that the training covered both detection and prevention.

##### Role-based anti-counterfeit training for hardware, software, firmware

- Category: Manual
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm SR-11(1) scope and defined roles; produce training requirements statement covering detection + prevention/response for hardware, software, and firmware | Compliance Manager | Enterprise | 8h | — |
| Create role-to-module training matrix (Supply Chain Security, Hardware/Firmware Engineering, Software Development, System Administration) mapping each role to hardware/software/firmware modules and required scenario coverage | Project Manager | Enterprise | 16h | — |
| Develop training content pack for three tracks (Hardware, Software, Firmware): indicators, decision points, evidence capture steps, quarantine/stop actions, vendor escalation, and escalation/reporting routes | Security Engineer | Department | 40h | — |
| Build scenario-based assessments and answer keys for each role (sequence selection, evidence requirements, escalation triggers) including pass/fail criteria and audit-friendly rationale | Quality Assurance Lead | Department | 24h | — |
| Configure LMS (or equivalent) for role-based assignment, completion gating for relevant privileged workflows, and exportable completion/assessment reporting fields | Learning Management Administrator | Enterprise | 24h | £3,000 |
| Implement audit record retention approach and templates (learner identity, role/module(s), completion date, assessment outcome, evidence that detection + prevention were covered) and validate retrievability | Data Protection Officer | Enterprise | 16h | — |
| Run initial delivery and completion monitoring; conduct completion drift checks and plan annual re-certification triggers (including supplier/process change events) | Service Delivery Manager | Enterprise | 20h | — |

**Total Estimated Effort:** 148h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Define and publish a table showing which training each role in supply chain security needs for supply chain security officers, hardware and firmware engineers, software developers, and system administrators.
- [ ] Create training materials with separate sections for detecting and preventing counterfeit indicators in hardware, software, and firmware.
- [ ] Create scenario-based checks that require a step-by-step response for handling suspicious components: stop, preserve evidence, escalate, quarantine, and verify.
- [ ] Set up a learning management system (LMS), or an equivalent tool, to assign training modules based on job role and require completion before any role-restricted, privileged work activities are allowed.
- [ ] Set up report exports that can be audited, recording the learner’s identity, the module identifiers, completion dates, and the results of assessments.
- [ ] Schedule regular re-certification and monitor any delays in completion by role, with management reporting.


---

#### SR-11.2 — Configuration Control for Component Service and Repair (Enhancement)

This requirement is about ensuring that every hardware and software item that is taken out of use for servicing or repair, and every item that has been serviced or repaired but is not yet back in use, is tracked and recorded accurately. Without this, the wrong part or software version could be put back into service, or an item could be altered without anyone noticing—leading to avoidable operational failures and increasing the risk that a faulty or tampered item is put back into use.

To meet this expectation, the organisation must keep a clear, up-to-date register of all in-scope items. For each item, it must record the item’s unique identity, its exact hardware details or software name and version, and whether it is awaiting service or repair, or awaiting return to service. The records must only be updated by authorised people, with a traceable record of what was changed and when. This must start when the item is removed from use and continue until an authorised return to service is recorded. The organisation must also keep relevant purchase and service documentation, and cover any work carried out by other organisations.

##### Service/repair component register with auditable status transitions

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define in-scope data model and mandatory fields for the service/repair component register (hardware/software identity, controlled states, custody/location, evidence references, vendor identifiers) | Configuration Management Lead | Enterprise | 24h | — |
| Design and implement workflow-driven status transitions with validation rules (awaiting service/repair → serviced/repaired—awaiting return; serviced/repaired—awaiting return → returned to service) | System Design Authority | Enterprise | 40h | — |
| Implement tamper-evident append-only audit logging for all create/update/transition/evidence-link events (immutable history, event correlation identifiers) | Security Engineer | Enterprise | 32h | — |
| Implement RBAC/authorisation controls for configuration control operators and approvers; enforce least privilege and deny unauthorised transitions with logged security events | Cyber Security Lead | Enterprise | 28h | — |
| Integrate pre-fill from enterprise asset inventory and software inventory; implement human confirmation step before record enters a controlled state | Platform Engineer | Business Unit | 36h | — |
| Enable third-party service/repair evidence capture and linkage (RMA/service report/test results references) with validation prior to controlled-state transitions | Compliance Manager | Department | 20h | — |
| Prepare audit-ready operational runbooks and evidence packs (how to retrieve audit trails, how to demonstrate authorised approvals, retention expectations, testing/assurance checklist) | Project Manager | Enterprise | 16h | — |

Total Estimated Effort: **216h**  
Total Estimated Cost: **£0**

###### Actions Required for Compliance

- [ ] Define the data model for the in-scope component `sr-11.02_odp`, including mandatory identity, the exact hardware and software configuration, and the two controlled states.
- [ ] Set up a process that only allows changes to and from the controlled states when there is supporting evidence reference and an authorised approval.
- [ ] Set up role-based access control (RBAC) so only authorised roles can create, update, or approve controlled-state records. Protect privileged actions with strong authentication.
- [ ] Set up audit logs for all register events so they can only be added to (append-only) and any changes are detectable (tamper-evident), and make sure the audit logs are kept for as long as required by the organisation’s policy.
- [ ] Link the register to the organisation’s hardware and software inventory so configuration details are filled in automatically, and require the operator to confirm the details when entering each state.
- [ ] Add fields and checks for third-party service or repair identifiers (for example, return merchandise authorisation (RMA) or service report references), and link them to the component record before authorising the component to be returned to service.


---

#### SR-11.3 — Anti-counterfeit Scanning (Enhancement)

This requirement is about regularly checking that the parts your systems depend on are genuine and have not been replaced with fake or altered components. If counterfeit components enter your technology, they can quietly reduce reliability, expose sensitive information, or introduce hidden weaknesses that are difficult to detect later—potentially leading to financial loss and disruption.

To meet this expectation, the organisation must scan for counterfeit system components at least once every week. It must use the right type of scanning for each component type (for example, using the appropriate approach for web-based components when they are involved).

The organisation must also keep clear records showing which scanning tools were used for each weekly scan, including tool details where relevant, and must keep the scan results as evidence that the weekly checks are being completed.

##### Weekly counterfeit component scanning with tool-evidenced results

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Establish authoritative component inventory structure (component types, target identifiers, environment mapping) and define scanning-to-component-type rules | System Design Authority | Enterprise | 24h | — |
| Implement scheduled weekly scanning workflow (CI/CD scheduled job or enterprise scheduler) that pulls latest inventory targets and triggers component-appropriate scanners | DevOps Lead | Enterprise | 48h | — |
| Integrate and configure component-appropriate scanners per component type (e.g., SAST/DAST for web, dependency scanning for libraries, image scanning for containers, artefact scanning for build outputs) | Security Engineer | Department | 56h | £18,000 |
| Implement evidence capture and evidence binding (tool metadata: name/version/config/profile/ruleset; target identifiers; immutable run ID; timestamps) and generate standard evidence schema (JSON + human-readable summary) | Compliance Manager | Enterprise | 40h | — |
| Build central access-controlled evidence store and retention/immutability controls (run retrieval by run ID; audit-friendly indexing; access logging) | Operations Lead | Enterprise | 32h | £6,000 |
| Implement triage routing for counterfeit-likely indicators (non-blocking scan completion; handoff to supply chain risk workflow; include evidence links and finding context) | Security Operations Lead | Department | 24h | — |
| Validate control effectiveness and acceptance criteria (weekly cadence enforcement, component-type scanning alignment, evidence completeness, audit walkthrough test) | Quality Assurance Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 248h  
**Total Estimated Cost:** £24,000

###### Actions Required for Compliance

- [ ] Define and keep an official, component-based list of all application parts and their dependencies.
- [ ] Set up a weekly scheduled scanning process that chooses scan targets from the inventory.
- [ ] Set up routing by component type so each component type uses the correct counterfeit scanning method.
- [ ] For every weekly scan run, record the scan tool’s name, version or build identifier, and the configuration or profile used.
- [ ] Store the original scan results and the cleaned, summarised versions in a single central evidence repository that only authorised people can access, using unique, unchangeable run identifiers.
- [ ] Create an audit-ready record that links each weekly run identifier to the component targets, the tools used (including their details), and the results.
- [ ] Add results that suggest possible counterfeiting into the supply chain risk and security review process, without stopping the weekly collection of evidence.


---

### SR-12 — Component Disposal (Control)

This requirement ensures that when we no longer need a computer, router, or other device, we remove and destroy anything sensitive on it so it cannot be read, misused, or resold. Without this, confidential information, sensitive documents, secret access codes, and data stored on the device could be recovered by unauthorised people, or the hardware could end up in the grey market.

The organisation must securely dispose of confidential and secret data, system documentation (paper or digital), cryptographic keys, and on-premises storage media on servers, routers, and end-user devices at any point in the device’s life (including during development, testing, day-to-day use, or maintenance). This means properly wiping or clearing storage, destroying cryptographic keys, using secure physical destruction when wiping is not enough, and confirming that the device has been decommissioned completely, with a documented handover record.

The organisation must also have clear policies and procedures for protecting the supply chain, assign named responsibilities, and keep disposal records showing which components were handled, what method was used, and how unauthorised access and grey-market risk were prevented.

##### SR-12 Disposal workflow with NIST 800-88 sanitisation evidence

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define SR-12 disposal workflow requirements, evidence standards, and mapping to `sr-12_odp.02` methods (including routing rules for “not reliably sanitised” → secure physical destruction) | Compliance Manager | Enterprise | 24h | — |
| Extend/confirm asset inventory schema and APIs to support disposal-trigger attributes (asset tag/serial, device/storage media type, environment prod/test/dev/DR, encryption/key ownership status, key identifiers, RMA/R&D/prototype indicators) | Data Protection Officer | Enterprise | 32h | — |
| Design and implement role-gated disposal request workflow with separation of duties (requester → operator → privileged verifier) and release gates blocking handover/export until evidence is attached | Software Lead | Enterprise | 56h | — |
| Implement sanitisation method selection engine and integration adapters (tool-generated sanitisation report IDs/hashes, decommissioning verification signals, and fallback routing to physical destruction) | Architect | Enterprise | 48h | £18,000 |
| Implement cryptographic key destruction evidence capture (KMS/CMK disable/retire operations, key version retirement records, signed attestations where applicable) and enforce mandatory step for in-scope key-bearing assets | Security Engineer | Enterprise | 40h | £6,000 |
| Build tamper-evident disposal dossier generation and retention (per-asset dossier containing method used, verification results, chain-of-custody trail, evidence artefacts, and audit metadata) | Platform Engineer | Enterprise | 40h | £12,000 |
| Implement chain-of-custody capture and third-party vendor controls (approved vendor list, custody transfer records, receiving/verification documentation ingestion) | Operations Lead | Enterprise | 24h | — |
| Testing, pilot rollout, and audit readiness (end-to-end disposal scenarios across prod/test/dev/DR and R&D/prototype scrap; evidence completeness checks; user training; runbook + monitoring/alerting) | Quality Assurance Lead | Enterprise | 48h | £4,000 |

**Total Estimated Effort:** 352h  
**Total Estimated Cost:** £40,000

###### Actions Required for Compliance

- [ ] Set up an SR-12 disposal process in the IT service management (ITSM) and asset system, with required fields for the in-scope item type, the asset identifiers, and the selected `sr-12_odp.02` disposal method.
- [ ] Integrate the workflow with the official asset inventory so that storage media and encryption and key ownership details are filled in automatically, enabling the correct method to be selected.
- [ ] Set up workflow “release gates” so the final handover and export cannot happen until sanitisation reports and verification evidence have been attached.
- [ ] For relevant assets, record proof that cryptographic keys are permanently destroyed or disabled (for example, by keeping key management system (KMS) logs or signed attestations).
- [ ] Require separation of duties by ensuring different people perform and verify the sanitisation, key destruction, and decommissioning sign-off.
- [ ] Record every handover in the chain of custody (who transferred it, the date and time, who received it, and the approved method of transfer), and store the disposal records in a tamper-evident repository.
- [ ] Test the full workflow from start to finish for at least one server, one router, and one endpoint disposal scenario across both production and non-production refresh events.


### PL-1 — Policy and Procedures (Control)

This requirement is about making sure the organisation has a clear, written plan for how it will protect people’s information and meet its privacy responsibilities, and that staff understand how to follow that plan in practice. Without this, different teams may work in different directions, legal and regulatory duties could be missed, and lessons from audits or real incidents might not lead to timely improvements—leaving the organisation exposed to avoidable harm.

The organisation must create and document an organisation-wide security and privacy planning policy. This policy must explain its purpose, what it covers, who is responsible for what, the leadership’s commitment, how departments work together, and how the organisation will meet compliance requirements in line with relevant laws, regulations, internal rules, and guidance.

The Chief Information Security Officer must oversee creating, documenting, and sharing the policy and the supporting procedures.

The policy must be reviewed and updated at least every year, and also after material regulatory or operational changes, audit findings, security incidents or breaches, major changes to the organisation’s design or architecture, and changes to key requirements. The procedures must be reviewed and updated at least every year, and also after material changes to processes or systems, new or updated requirements, major lessons from incidents, changes to roles, and major changes to how systems are integrated.

##### CISO-owned security & privacy planning policy and procedures framework

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Draft organisation-level “Security & Privacy Planning Policy” (purpose, scope, management commitment, roles/responsibilities, coordination between security & privacy programmes, compliance alignment, governance model) | Compliance Manager | Enterprise | 24h | — |
| Define and document planning governance (policy owner accountability, approval workflow, escalation routes, RACI for risk/compliance/security/privacy inputs, control owner contribution model) | Project Manager | Enterprise | 16h | — |
| Develop “Security & Privacy Planning Procedures” (how risk management strategy informs planning, how programmes collaborate, how planning outputs are produced/approved, evidence generation requirements, audit support approach) | Security Engineer | Enterprise | 28h | — |
| Create controlled dissemination pack (publication method, recipient lists for policy vs procedures, version control approach, acknowledgement/attestation mechanism, and communication plan) | Operations Lead | Enterprise | 10h | — |
| Establish review/update triggers and cadence with record-keeping (annual review plus defined triggers: audit findings, incidents/breaches, regulatory/standards changes, major architecture/process changes; define procedure review triggers and minimum evidence to retain) | Compliance Manager | Enterprise | 14h | — |
| Produce standard templates and evidence pack checklist (system/mission planning inputs for security plan and privacy plan, required sections, minimum evidence artefacts, and guidance to prevent local variants) | Software Lead | Enterprise | 20h | — |
| Run policy/procedure validation workshops and final approval (security & privacy programme leadership, risk management, compliance; incorporate feedback; obtain CISO approval and publish) | Cyber Security Lead | Enterprise | 18h | — |

| Total Estimated Effort | 130h | Total Estimated Cost | £0 |

###### Actions Required for Compliance

- [ ] Draft and get approval for an organisation-wide security and privacy planning policy, owned by the Chief Information Security Officer (CISO).
- [ ] Define and document planning procedures that explain how risk information is used to plan work, and how evidence of planning is produced.
- [ ] Publish the policy and procedures in a controlled repository and share them with the specified recipient groups.
- [ ] Create standard templates and an evidence pack checklist that system owners can use when producing planning outputs.
- [ ] Set and document review and update schedules: review the policy every year and whenever defined triggers occur; review the procedures every year and whenever defined triggers occur.
- [ ] Record and keep the results of reviews and the reasons for any changes so they can be audited (including version history, approval records, and distribution logs).


---

### PL-2 — System Security and Privacy Plans (Control)

This requirement is about making sure the organisation has clear, up-to-date plans for how each system will be run safely and how it will protect people’s privacy. Without these plans, important details are more likely to be missed—such as what the system does, what information it uses, who is responsible, what other systems it connects to, which risks matter, and what safeguards are in place—leading to avoidable misuse of data, privacy harm, or security weaknesses.

To meet this expectation, the organisation must create and keep two documents for each system: a **system security plan** and a **system privacy plan**. These plans must match the organisation’s overall system blueprint, describe the system’s components and operating environment, name the responsible people, list the information involved, explain the chosen risk level and why, describe the key threats, include the results of privacy risk checks for personal data, and summarise the security and privacy measures (including any justified changes), as well as the risk decisions behind key design choices.

Before the plans are used, they must be reviewed and approved by the authorising official. They must be shared with the system owner, authorising official, security assessor, and privacy officer. They must be updated at least once a year and whenever major changes occur, and they must be protected so that unauthorised people cannot view or edit them.

##### Maintain authorisation-approved security & privacy plan per system boundary

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish/maintain system boundary register entry for the application/service, including mapping to the authorisation boundary and links to enterprise architecture artefacts (service catalogue, integration map, reference architecture) | System Design Authority | Enterprise | 16h | — |
| Create and configure the controlled “system security & privacy plan” template in the document/GRC system (required sections, evidence link fields, structured control mapping fields, parameter/tailoring capture, change history fields) | Compliance Manager | Enterprise | 24h | £6,000 |
| Populate the plan set content for the system: system components, operational context, information types processed/stored/transmitted, security categorisation rationale, and threats of concern | Security Engineer | Enterprise | 32h | — |
| Perform/confirm privacy risk assessment results where personal data is processed and integrate outcomes into the privacy plan sections (data flows, roles, risk outcomes, and required privacy control implications) | Data Protection Officer | Enterprise | 24h | — |
| Map selected security/privacy controls to system context with explicit tailoring/parameter values (by value or reference to controlling standard/baseline) and link to implementation/evidence documents | Security Engineer | Enterprise | 40h | — |
| Document key security/privacy architecture decisions and risk determinations with references to design/implementation documents (without embedding full technical specs) | Architect | Enterprise | 16h | — |
| Implement lifecycle governance: define update triggers (annual + major system/environment changes), run approval workflow to authorising official, set controlled distribution list, and enforce access protection (view/edit restrictions) with auditable records | Project Manager | Enterprise | 24h | £2,500 |
| Conduct annual review readiness pack: verify completeness, evidence links, and change history; produce an auditable review record and action log for assessor/approval stakeholders | Compliance Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 192h  
**Total Estimated Cost:** £8,500

###### Actions Required for Compliance

- [ ] Create or update the system boundary register and link it to the enterprise architecture records for the application and its integrations.
- [ ] Create the system security and privacy plan(s) using a controlled template that includes mandatory sections covering: the system components, the context, the types of information handled, the reasons for how information is categorised, the identified threats, and the expected privacy risk outcomes.
- [ ] For each chosen control or improvement, link it to the system context and record any tailoring or setting choices using the exact value or a clear reference.
- [ ] Record the main security and privacy architecture decisions and the related risk assessments, and refer to the detailed design and implementation documents when needed.
- [ ] Route the plan for authorising official review and approval before any implementation or major release change.
- [ ] Provide controlled copies to the system owner, the authorised official, the security control assessor, and the system privacy officer, and record proof that the copies were distributed.
- [ ] Review the plan at least once every year and also after major system or environment changes, and put in place access controls to stop unauthorised people from viewing or editing it.


---

### PL-4 — Rules of Behavior (Control)

This expectation is about making sure everyone who is allowed to use your organisation’s systems understands the rules for doing so and agrees to follow them. Without clear, agreed rules, people may accidentally misuse information, mishandle sensitive data, or ignore privacy responsibilities. This can lead to security incidents, financial loss, reputational damage, and harm to customers or staff.

To meet this expectation, the organisation must:
- Write clear, plain-language rules for how people should behave when using information and systems, including what is expected for security and privacy.
- Give these rules to each person before they are granted access.
- Collect a recorded acknowledgement from each person (for example, a signed form or an electronic agreement) confirming they have read, understood, and agreed to comply.
- Not grant access until the acknowledgement has been recorded.

The organisation must also:
- Review and update the rules at least every 12 months.
- When changes are made, require people who previously acknowledged the rules to read the updated version and re-acknowledge within 30 days.
- Keep records of reviews and updates.

##### IAM workflow gate for role-based Rules of Behaviour acknowledgement

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define role-based “Rules of Behaviour” variants (general, privileged, and any additional responsibility variants) including attestation wording, required metadata fields, and enforcement options for re-acknowledgement | Compliance Manager | Enterprise | 24h | — |
| Create controlled, versioned rules content workflow (authoring, approval, supersession, 12-month review cadence; publish “current version” pointers) | Compliance Manager | Enterprise | 32h | — |
| Implement IAM workflow gate: block provisioning/access until acknowledgement exists for the current rules version (including mediated IT/OT access path integration points) | Identity Platform Team | Department | 56h | — |
| Configure acknowledgement capture in the access journey (electronic agreement UI; record user identity, rules document name/version, timestamp, and attestation text; ensure idempotency for retries) | Security Engineer | Department | 40h | — |
| Implement re-acknowledgement automation on rules updates (identify affected users, flag within 30-day window, enforce restriction/revocation method, and prevent access until completion) | DevOps Lead | Enterprise | 48h | — |
| Build audit evidence store and reporting (map acknowledgement events to rules versions; ensure retrieval for audits; integrate with IAM audit logs/SIEM-ready outputs) | Data Protection Officer | Enterprise | 32h | — |
| End-to-end testing and operational readiness (test cases for new users, privileged vs general variants, update/supersession, 30-day enforcement, failure modes; runbook and monitoring/alerting) | Quality Assurance Lead | Department | 40h | £6,000 |
| Pilot rollout and change management (select user cohort, validate operational constraints with Application Owner, remediate gaps, then scale to production) | Project Manager | Business Unit | 24h | £3,000 |

**Total Estimated Effort:** 296h  
**Total Estimated Cost:** £9,000

###### Actions Required for Compliance

- [ ] Create version-controlled “Rules of Behaviour” documents for both general users and privileged users, with named owners and scheduled review dates.
- [ ] Set up the identity and access management (IAM) access request process so that the correct rules for the user’s role are shown before any provisioning step is started.
- [ ] Add an electronic acknowledgement (a checkbox or radio button) that records the user’s identity, the rules version, and the date and time (timestamp).
- [ ] Put a control in place that blocks access until the current rules version has been acknowledged and recorded.
- [ ] Automatically send re-acknowledgement reminders when rules are updated, and require completion within 30 days to keep access active.
- [ ] Store and keep audit evidence showing which user acknowledgement relates to the specific version of the rules and the associated review or update activity.


---

#### PL-4.1 — Social Media and External Site/Application Usage Restrictions (Enhancement)

This requirement is about making sure staff use social media and other public websites or apps responsibly, especially when they are acting on behalf of the organisation. Without clear rules, people could accidentally share confidential or personal information publicly, harm the organisation’s reputation, or create accounts on external services in ways that expose sensitive access details.

To meet this expectation, the organisation must publish clear, written rules for how staff should behave when using social media, social networking sites, and external websites or applications for official duties. These rules must explain when and how organisational information may be posted on public pages, and they must require prior approval before any organisational information is published publicly.

The rules must also prohibit staff from using organisation-provided identifiers (such as work email addresses) and authentication secrets (such as passwords) to create external accounts, unless an approved exception process is in place.

The organisation must appoint named people to manage these rules, review and update them when needed, and share them with authorised staff. Staff must sign to confirm they have read and understood the rules. The organisation must also support the rules with relevant procedures and role-based training, and keep evidence that the rules and training are in place.

##### External communications rules with approval and account-creation exceptions

- Category: Manual
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Draft the authoritative “External Communications & External Account Creation Rules of Behaviour” document, including scope/definitions (social media, external sites/apps, official duties, organisational information, non-public information incl. PII and system account information) | Compliance Manager | Enterprise | 24h | — |
| Define and document posting restrictions and approval requirements (content categories, what may/cannot be posted publicly, approval authority per category, required handling of non-public organisational information) | Compliance Manager | Enterprise | 16h | — |
| Define and document external account creation restrictions (explicit prohibition on using organisational identifiers and authentication secrets; exception/authorisation process requirements including justification, compensating controls, and named approver) | Data Protection Officer | Enterprise | 16h | — |
| Establish named responsibilities and governance cadence (owners for document maintenance, exception review, periodic review frequency; RACI for posting approvals and account-creation exceptions) | Security Governance Lead | Enterprise | 10h | — |
| Implement operational workflow for approvals and exceptions (ticket/workflow route, required fields, audit trail expectations, retention guidance, and decision recording standards) | Service Delivery Manager | Enterprise | 20h | — |
| Create acknowledgement and training pack (role-based training content, onboarding/role-change re-acknowledgement requirements, evidence capture approach, and reporting template for audit sampling) | Quality Assurance Lead | Enterprise | 18h | — |
| Run pilot and produce audit-ready evidence set (test workflow with sample requests, validate recorded approvals/justifications, confirm acknowledgements/training evidence, and incorporate lessons learned into final version) | Project Manager | Enterprise | 14h | — |

**Total Estimated Effort:** 118h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Create and publish a version-controlled document called **“External Communications & External Account Creation Rules of Behaviour”**. The document must clearly define what counts as non-public information, including **personal data (PII)** and **system account information**.
- [ ] Set rules that restrict what can be posted publicly on social media and on external websites or applications, and require prior approval before any organisational information is released.
- [ ] Set out and publish clear rules that forbid using organisational identifiers and authentication secrets to create external accounts, and include the specific conditions under which exceptions are allowed.
- [ ] Set up an auditable process for (a) approving public posts and (b) approving exceptions to external account creation, recording who approved it and the reason for the approval.
- [ ] Assign named owners to maintain the rules, review exceptions, and update the content, and set a regular review schedule.
- [ ] Roll out role-based training and require authorised staff to confirm they understand the rules during onboarding or when their role changes, and then again at regular intervals.
- [ ] Keep records showing acknowledgements, completion of training, and a sample of recent approvals or exceptions for postings for audit purposes.


---

### PL-7 — Concept of Operations (Control)

This requirement is about having a clear, up-to-date “how we will run it” plan for each system. The plan should explain how the organisation will protect information and handle people’s privacy in everyday work. Without this, teams may run the system in different ways, miss important privacy steps, or fail to update procedures when the system changes. This increases the risk that data is mishandled, personal information is used incorrectly, or responsibilities are unclear during incidents.

To meet this expectation, the organisation must create a **Concept of Operations** that describes how the system will be operated from both an information protection and privacy perspective. It must be stored in the system’s planning documents (such as the security and/or privacy plan) and treated as a “living document”.

The Concept of Operations must be reviewed at least every 12 months, and also whenever there are material changes to how the system operates, how it is built, or the organisation’s security or privacy requirements. Updates must be made when the review shows the document is no longer accurate.

##### Controlled, system-specific CONOPS with annual and change-trigger reviews

- Category: Manual
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create system-specific CONOPS template (per application) including security and privacy sections, roles/responsibilities, operational procedures, and explicit alignment to planned controls/architecture | System Design Authority | Enterprise | 24h | — |
| Produce initial system-specific CONOPS for the target application and populate required sections (security-relevant operations, privacy-relevant operations, operational procedures, handoffs, DR/backup operations) | System Design Authority | Business Unit | 32h | — |
| Implement document control packaging: register CONOPS in controlled document management (versioning, metadata, access restrictions, named owner) and ensure security plan/privacy plan reference the current CONOPS with document name and section pointers | Compliance Manager | Enterprise | 16h | — |
| Define SDLC gate checks and evidence requirements: update design review and go-live checklists to require CONOPS consistency evidence and security/privacy sign-off | Project Manager | Enterprise | 20h | — |
| Establish annual review workflow and material-change trigger mechanism linked to change/architecture records (including review cadence, reviewers, decision criteria, and escalation path) | Compliance Manager | Enterprise | 20h | — |
| Create review evidence record format and update process: capture review date, reviewers, outcome (updated/no change), and section-level change mapping; ensure updates propagate to security/privacy plans when applicable | Data Protection Officer | Enterprise | 16h | — |
| Run first annual (or immediate) review cycle for the target application and complete audit-ready evidence pack (including outcomes and any reflected updates to security/privacy plans) | Compliance Manager | Business Unit | 12h | — |

| Total Estimated Effort | 140h |  |
|---|---:|---:|
| Total Estimated Cost | — | £0 |

###### Actions Required for Compliance

- [ ] Create a CONOPS (concept of operations) template for each system that covers day-to-day security and privacy procedures, and shows how these procedures align with the planned controls and the system’s architecture.
- [ ] Publish the concept of operations (CONOPS) in a controlled document management system, with a named owner, version control, and restricted access.
- [ ] Update the system security plan and/or privacy plan to point to the latest CONOPS (include the document name and the relevant section references).
- [ ] Set requirements for the software development lifecycle (SDLC) gates so that design reviews and go-live only proceed when there is evidence that the concept of operations (CONOPS) is consistent and has been formally approved (signed off).
- [ ] Set up a review process that runs at least once every year for the concept of operations (CONOPS), involving security and privacy reviewers, and requires a mandatory completion checklist.
- [ ] Link the trigger points for reviewing the concept of operations (CONOPS) to change management, so that any material changes to operations, architecture, or security and privacy requirements start an immediate review.
- [ ] Keep an auditable review record that shows the review date, who reviewed, the result, and what changed in each section, with a clear link to the related plan updates.


---

### PL-8 — Security and Privacy Architectures (Control)

This requirement is about creating, documenting, and regularly updating a clear plan for how your system will protect information and people’s personal data, and how that plan fits with the organisation’s wider overall design. Without this, confidential business information could be exposed, records could be changed or damaged, services could become unavailable, and personal data could be handled in ways that cause avoidable privacy harm.

To meet this expectation, the organisation must produce two documents for the system: a security plan and a privacy plan. Together, they must explain what needs to be protected, how personal data will be handled to reduce privacy risk, how the system’s approach matches the organisation’s overall architecture, and what the system depends on from external suppliers or services.

These plans must be reviewed at least every year, and also whenever the organisation’s overall architecture changes. Any planned changes must then be reflected in the system’s security plan, privacy plan, day-to-day operating description, importance and recovery priorities, internal procedures, and procurement or purchasing documents. Records must be kept showing the reviews and updates.

##### Versioned security & privacy architecture with interface protection

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Draft combined system security & privacy architecture (including CIA objectives, trust boundaries, component responsibilities, allocated security/privacy controls) | System Design Authority | Department | 56h | — |
| Produce external interface protection section (for each external interface: exchanged information, integrity/confidentiality/authn/authz approach, encryption in transit/at rest, logging/monitoring hooks, privacy-relevant handling, and dependency assumptions) | Security Engineer | Department | 48h | — |
| Create enterprise alignment mapping to PM-7 and enterprise architecture target state (reference components, standards/patterns, and explicit traceability to enterprise security/privacy architectures) | Compliance Manager | Enterprise | 32h | — |
| Establish architecture review workflow and evidence pack (annual review trigger + EA-change-triggered review, review record template, approvals/change log, and SDLC artefact update checklist) | Project Manager | Enterprise | 24h | — |
| Integrate architecture outputs into design reviews and procurement packs (update preliminary/critical design review checklists; produce RFP/RFQ requirement insert for interface protection and dependency expectations) | Service Delivery Manager | Business Unit | 40h | — |
| Implement configuration-controlled baselines (set up versioning/change control linkage, repository structure, baseline-to-deployed-design traceability, and audit-ready retention of evidence) | Operations Lead | Department | 32h | £2,500 |
| Run initial architecture review and produce update evidence (first baseline review, incorporate feedback, and confirm traceability into security plan, privacy plan, CONOPS, restoration/criticality priorities, and procurement requirement packs) | Compliance Manager | Business Unit | 24h | — |

**Total Estimated Effort:** 276h  
**Total Estimated Cost:** £2,500

###### Actions Required for Compliance

- [ ] Create a configuration-controlled system security and privacy plan that covers confidentiality, integrity, and availability (CIA), how personal data is processed (including personally identifiable information (PII)), and the specific controls assigned to each area.
- [ ] Clearly link the system design to the organisation-wide security and privacy architectures described in PM-7, and to the enterprise architecture target state.
- [ ] Document each external interface, including: what information is exchanged, the security and privacy requirements, and the protection measures used for that interface.
- [ ] Identify and record any external dependencies and assumptions for outside information services or providers, including what availability is expected and how data will be handled.
- [ ] Set up a review process that runs every year and also whenever an Enterprise Architecture (EA) change is made, and keep the proof of each review (approvals, the change record, and the reasons for the decision).
- [ ] Update the downstream documents (security plan, privacy plan, concept of operations/operational description, restoration priorities, and procurement requirement packs) whenever the architecture changes.


---

#### PL-8.1 — Defense in Depth (Enhancement)

This requirement is about building security and privacy in layers, so an attacker has to get past several protections before they can cause harm. Without this, a single weak point could allow someone to enter the wrong part of your systems, pretend to be a user, read or change sensitive information, or hide their actions for longer—making damage more likely and problems harder to detect in time.

The organisation is expected to design both its security and privacy plans using a defence-in-depth approach. This means putting in place, and coordinating, measures such as: network separation; extra identity checks (for example, a code sent to a phone); only giving people the minimum access they need; protecting data both when it is stored and when it is sent; using standard safe settings; and ongoing alerts and checks across key areas including the perimeter and internal networks, the boundary between operational technology and information technology, computers and applications, data storage, and the monitoring layer. The organisation must also ensure these measures work together without interfering with each other, and document how they are coordinated.

##### Defense-in-depth architecture with coordinated layered control allocation

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce defence-in-depth security architecture allocation matrix mapping required controls (segmentation, MFA, least privilege, encryption in transit/at rest, secure configuration baselines, continuous monitoring) to defined layers/locations (perimeter/internal zones, OT/IT boundaries, host/app/data/monitoring layers) | System Design Authority | Enterprise | 40h | — |
| Define trust boundaries and allowed flows between layers/zones, including OT/IT demilitarised boundaries, and document how segmentation constrains lateral movement and limits blast radius | Network/OT Security Engineer | Enterprise | 32h | — |
| Create coordination/guardrails specification to prevent unintended consequences: administrative access paths (including break-glass with compensating controls), monitoring/detection tuning rules to avoid alarm storms, and rollback/exception handling runbooks for segmentation/baseline enforcement blocks | Security Architecture Lead | Enterprise | 36h | — |
| Produce security architecture document (audit-ready) including architectural decisions, assumptions, rationale for each control-to-layer allocation, and traceability to implementation standards (baseline templates, identity policy requirements, logging/detection coverage expectations) | Compliance Manager | Enterprise | 28h | — |
| Produce privacy architecture document using the same layered allocation logic (layered access restrictions, secure transport/storage, and monitoring for unauthorised access to personal data), including privacy-specific trust boundaries and allowed flows | Data Protection Officer | Enterprise | 28h | — |
| Establish audit evidence structure and operational traceability: decision records, mapping from allocation matrix to build/deploy/change standards, and review checklist for security/privacy architecture sign-off | Project Manager | Enterprise | 20h | — |
| Conduct architecture review workshops (IAM, Network/OT, Application/Data Security, SOC/Monitoring) and incorporate feedback to finalise the coordinated layered design and guardrails | Project Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 208h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Create a security architecture allocation matrix that shows which security controls apply to each defined layer/location, covering network segmentation, multi-factor authentication (MFA), least privilege, encryption for data stored and data sent over networks, secure configuration baselines, and continuous monitoring.
- [ ] Create a privacy architecture allocation matrix that uses the same layered allocation approach to protect personal data across the same layers and locations.
- [ ] Set clear “trust boundaries” and define which network, application, and data connections are allowed between: perimeter and internal zones; the operational technology (OT) and information technology (IT) demilitarised boundaries; the host and application layers; the data layer; and the security monitoring layer.
- [ ] Set document coordination guardrails (for example, a “break-glass” emergency process, clear rules for handling exceptions and rolling back changes, and monitoring alert-tuning) to prevent user lockouts and repeated, overwhelming alarm notifications.
- [ ] Record the reasons and assumptions behind how each control is assigned to a layer, so there is clear, audit-ready evidence linking decisions to the system design.
- [ ] Review the system design with the leads for identity and access management (IAM), network and operational technology (OT) security, application and data security, and the security operations centre (SOC), and obtain formal approval.


---

#### PL-8.2 — Supplier Diversity (Enhancement)

This requirement is about not using one supplier for the key security tools used across different parts of your business. The goal is to reduce the risk that a weakness in one supplier’s product could affect both your main on-site data centre systems and your operational technology (OT) network areas. If you use the same supplier everywhere, the same security gap could exist in both places.

To reduce this risk, the organisation must ensure that the security tools used for malware protection, tools that help detect suspicious activity on devices, and tools that record what happened on systems are bought from different suppliers for the on-premises data centre environment than for the OT network segments.

The organisation should include this in its purchasing rules, confirm before buying that the suppliers are different, and keep clear records showing which supplier was chosen for each tool in each environment. This should also include any approved exceptions, with the reasons, if the same supplier cannot be used.

##### Enforce supplier diversity for in-scope security controls by environment

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define supplier-diversity policy model (control types, environments/architectural layers, mapping rules, diversity comparison logic, and exception triggers) | Compliance Manager | Enterprise | 24h | — |
| Extend procurement/architecture workflow data model to capture supplier selections per in-scope control type and environment (including required fields and validation constraints) | Project Manager | Enterprise | 32h | — |
| Implement policy-as-code validation in workflow engine to block approval when supplier(environment A, control type) = supplier(environment B, control type) for any in-scope pair | Software Lead | Enterprise | 56h | £18,000 |
| Build auditable evidence capture and reporting (supplier names, control type, environment mapping, approver identity, timestamps, references to approved artefacts) | Quality Assurance Lead | Enterprise | 24h | — |
| Implement controlled exception workflow (exception request form, compensating measures, approval decision trail, expiry/review dates, and audit linkage) | Compliance Manager | Enterprise | 24h | — |
| Integrate architecture approval artefacts to reference chosen suppliers per environment/control type and add consistency checks (planned deployment consistency linkage) | System Design Authority | Enterprise | 20h | — |
| Pilot rollout with representative systems and conduct compliance testing (positive/negative cases, regression checks, and sign-off against acceptance criteria) | Service Delivery Manager | Enterprise | 28h | £6,000 |
| Training and operational handover (workflow guidance, exception handling, evidence expectations, and runbook updates) | Operations Lead | Enterprise | 16h | — |

**Total Estimated Effort:** 244h  
**Total Estimated Cost:** £24,000

###### Actions Required for Compliance

- [ ] Set out the security-relevant control types that are in scope for {{ insert: param, pl-08.02_odp.01 }} and the in-scope environments and architectural layers for {{ insert: param, pl-08.02_odp.02 }}
- [ ] Create a supplier-diversity policy model that links each in-scope control type to each in-scope environment, with the rule that the supplier used in one environment must be different from the supplier used in another environment (supplier in environment A ≠ supplier in environment B).
- [ ] Update the procurement and IT service management (ITSM) purchase request forms to record which supplier is selected for each in-scope control type and each environment.
- [ ] Set up automated checks in the workflow system to enforce the diversity rule, so approvals are blocked when supplier selections do not meet it.
- [ ] Add an architecture approval gate that requires the system security plan and architecture documents to name the selected suppliers for each environment and control type.
- [ ] Set up an auditable process for exceptions when diversity requirements cannot be met, including the reason for the exception and the compensating measures taken.


---

### PL-9 — Central Management (Control)

This requirement is about managing security and privacy work from one place in the organisation, so the same rules are followed everywhere. Without this, different teams might use different ways of working, which can create weak spots that attackers (or simple mistakes) could take advantage of. Examples include unauthorised access, poor handling of user accounts, weak control of changes, missing records of what happened, slow detection of problems, or unclear plans for protecting personal data.

To meet this expectation, the organisation must centrally plan, set up, check, formally approve, and keep under ongoing review the security and privacy measures it chooses. This includes deciding and controlling things such as who can access systems, how accounts are created and updated, how important events are recorded and monitored, how changes are approved and verified, how incidents and unusual events are handled, how data is protected, and how system and privacy planning is documented.

Where full central management is not possible, the organisation must clearly operate a hybrid approach: the parts that can be managed centrally must be managed centrally, and the remaining parts must be managed at system level.

##### Central control plane for centrally managed controls and evidence

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Produce version-controlled “control packs” for all pl-09_odp items (AC-2(1..4), AC-4(all), AC-17(1..3,9), AC-18(1,3..5), AC-19(4), AC-22, AC-23, AT-2(1..4), AU-3, AU-6(1,3,5,6,9), AU-7(1..2), AU-11, AU-13, AU-16, CA-2(1..3), CA-3(1..3), CA-7(1), CA-9, CM-2(2), CM-3(1,4), CM-4, CM-6, CM-6(1), CM-7(2,4,5), CM-8(all), CM-9(1), CM-10, CM-11, CP-7(all), CP-8(all), SC-43, SI-2, SI-3, SI-4(all), SI-7, SI-8) including enforcement points, required telemetry/logging, and evidence artefacts | Compliance Manager | Enterprise | 80h | — |
| Define and document the hybrid management boundary (centrally managed vs system-level) including compensating controls, system-level evidence requirements, and governance rules for exceptions | Compliance Manager | Enterprise | 40h | — |
| Design the central enforcement services blueprint aligned to the control packs (IdP/role & least-privilege enforcement; SIEM routing/schema/retention/alerting; configuration/change governance baselines and drift detection; planning/runbooks and reporting templates) | System Design Authority | Enterprise | 56h | — |
| Implement central identity/access enforcement for AC-2/AC-4/AC-17/AC-18/AC-19/AC-22/AC-23 (IdP policy configuration, role model mapping, privileged access constraints, and integration hooks for evidence capture) | Security Engineer | Enterprise | 64h | £15,000 |
| Implement central audit logging and monitoring pipelines for AU-3/AU-6/AU-7/AU-11/AU-13/AU-16 (SIEM event routing, normalised schemas, retention alignment, alerting rules, and evidence-ready log extracts) | DevOps Lead | Enterprise | 72h | £25,000 |
| Implement configuration/change governance automation for CM-2/CM-3/CM-4/CM-6/CM-7/CM-8/CM-9/CM-10/CM-11 (standard baselines, drift detection, change approval/verification workflow integration, and evidence generation) | Platform Engineer | Enterprise | 88h | £20,000 |
| Build automated assessment and evidence packaging (scheduled control checks across dev/test/prod/DR, compliance scoring, evidence bundle generation referencing control packs, and audit-ready traceability) | Software Lead | Enterprise | 96h | £30,000 |
| Integrate assessment outputs into authorisation/continuous monitoring workflow (remediation tracking to closure, dashboards, risk-based reporting, and operational runbooks for ongoing monitoring) | Project Manager | Enterprise | 48h | — |

**Total Estimated Effort:** 544h  
**Total Estimated Cost:** £90,000

###### Actions Required for Compliance

- [ ] Define and publish centrally managed control packs that cover every control and process item listed in `pl-09_odp`, including where the controls must be enforced and the evidence documents that must be produced.
- [ ] Document the “hybrid boundary” for any requirements that cannot be enforced centrally, and set out the compensating controls and what system-level evidence will be expected.
- [ ] Put in place central controls to enforce access to accounts, to record and monitor audit activity, and to manage configuration and change approvals in line with the control packs.
- [ ] Set up security information and event management (SIEM) and monitoring pipelines to standardise how events are collected, linked together, used to generate alerts, and kept for centrally managed audit requirements.
- [ ] Automate scheduled checks to confirm baseline compliance, logging coverage, adherence to access rules, and completeness of change records, and produce evidence packs that can be audited for each system and environment.
- [ ] Use the results of assessments in the organisation’s approval process and ongoing monitoring, including tracking fixes until they are fully completed.


---

### PL-10 — Baseline Selection (Control)

This requirement is about choosing the right protection package for a system before anything goes wrong. If the organisation does not start with a sensible set of security and privacy measures, it may end up not protecting important information enough. This could lead to data being lost, damaged, or misused; disruption to services; harm to individuals; breaches of legal or contractual duties; and wider effects on other organisations or the wider nation.  

To meet this expectation, the organisation must:  
- analyse what information the system handles and how it is used  
- assess what harm could happen if the system or information is lost or compromised  
- use the results of both system-level and organisation-wide risk reviews to decide which protection package to apply  

The chosen package must also reflect stakeholder needs, the organisation’s mission and business requirements, and any legal, regulatory, policy, or contractual requirements. This includes any add-ons that the organisation or the federal government has already approved as required.  

Finally, the organisation must record which protection package was chosen, the reasons for the choice, and evidence that it was formally approved by authorised personnel.

##### Risk-informed baseline selection with documented rationale and approval

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create system baseline intake pack (system boundary, architecture overview, environment segregation, data inventory mapped to NIST information types, and data-flow summaries per environment) | System Design Authority | Enterprise | 24h | — |
| Compile mandates register for the application (laws/regulations/policies/standards/contractual requirements plus any required enterprise overlays/add-ons) | Compliance Manager | Enterprise | 20h | — |
| Run baseline selection workshop and capture stakeholder needs (Security, Privacy where applicable, Risk, Architecture, Service Owners) including confidentiality/integrity/availability expectations and operational constraints | Project Manager | Enterprise | 16h | — |
| Perform impact/criticality analysis per information type and processing mode (store/process/transmit) to determine adverse impact across operations/assets/individuals/other organisations/Nation dimensions | Security Engineer | Enterprise | 28h | — |
| Use system and organisational risk assessment results to justify baseline choice (risk appetite, standard exceptions, common control gaps; map risk drivers to baseline selection rationale) | Compliance Manager | Enterprise | 20h | — |
| Select named NIST SP 800-53 control baseline and document tailoring decisions (what is added/removed, traceability to mandates, stakeholder needs, information types, impact analysis, and risk outputs) | Security Architect | Enterprise | 24h | — |
| Obtain formal approval and publish audit-ready baseline selection record (controlled repository, versioning, access controls; ensure downstream security/privacy planning references the approved record) | Cyber Security Lead | Enterprise | 12h | — |

Total Estimated Effort: **144h**  
Total Estimated Cost: **£0**

###### Actions Required for Compliance

- [ ] Put together a system intake pack for each environment, including the types of information handled and how it moves through the system (stored, processed, and transmitted).
- [ ] Create and keep up to date a register of requirements (the “mandates register”) that lists the baseline overlays and add-ons the system must have.
- [ ] Run an initial workshop to agree on the baseline by capturing stakeholders’ needs and limitations
- [ ] For each type of information and each way it is processed, carry out an impact and criticality assessment using the adverse impact dimensions.
- [ ] Review the system-level and organisational risk assessment results, and link them to the reasons for choosing the baseline.
- [ ] Choose the approved baseline and record any tailoring decisions, with clear traceability to the requirements (mandates), the impact assessment, and the risk results.
- [ ] Get formal approval from authorised roles and save the baseline selection record in a controlled, version-managed repository.


---

### PL-11 — Baseline Tailoring (Control)

This requirement is about making sure your organisation’s security and privacy plans fit your actual situation, rather than being copied from a generic template. Without this, you may waste time on protections that do not matter to your business, or you may miss important safeguards because you did not properly consider your organisation’s purpose, how your systems work, the types of harm that could realistically happen, and other factors that could affect success.

To meet this expectation, the organisation must:
- choose the starting set of security and privacy requirements
- decide what to change, add, remove, or adjust
- record clear reasons for each decision, using business impact or criticality analysis, risk assessments, and the organisation’s approach to risk
- decide which parts of the system the requirements apply to
- identify shared protections
- choose alternative protections if anything is reduced
- set any required settings
- add extra measures where gaps are found

Finally, the organisation must update and keep records in its system security plan and privacy plan. This should be supported by relevant design information, information about data, stakeholder information, and information from provider contracts, with named people responsible for planning and implementation.

##### Tailoring pipeline to generate justified PL-11 security/privacy baselines

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish tailoring workflow requirements and acceptance criteria (tailoring actions, mandatory fields, approval gates, audit evidence model) | Compliance Manager | Enterprise | 16h | — |
| Build baseline catalogue schema and controlled repository structure (selected baselines, overlays, common controls, candidate compensating controls, metadata and versioning) | System Design Authority | Enterprise | 24h | £3,000 |
| Implement decision-record data model and UI/API for tailoring actions (add/remove/adjust/parameterise/supplement/common-control designation/requirement allocation) with evidence-link support | Software Lead | Enterprise | 56h | £12,000 |
| Develop policy-as-code validation and publication rules (overlay constraints, compensating-control equivalence/coverage checks, mandatory rationale completeness, scoping consistency) | Security Engineer | Enterprise | 48h | £8,000 |
| Generate tailored plan outputs (tailored control set, implementation information, requirement allocation to system elements and external providers) mapped into system security plan and privacy plan templates | Platform Engineer | Enterprise | 40h | £2,500 |
| Integrate with lifecycle artefacts for scoping accuracy (links to trust boundaries, data flows, environment segregation, data classification, and risk assessment outputs) | Operations Lead | Enterprise | 24h | — |
| Implement review/approval workflow with named approvers, exception handling, and immutable version history (audit trail from decision records to published plans) | Project Manager | Enterprise | 32h | £4,000 |
| Conduct end-to-end pilot tailoring for a representative application baseline set and remediate gaps (test cases, audit-readiness checks, sign-off) | Quality Assurance Lead | Business Unit | 24h | — |

**Total Estimated Effort:** 264h  
**Total Estimated Cost:** £29,500

###### Actions Required for Compliance

- [ ] Create a controlled baseline catalogue that includes selected baselines, approved add-ons (overlays), common controls, and proposed compensating controls.
- [ ] Create a structured decision template for tailoring, with mandatory fields for: the scope, the parameter values, the mapping of compensating controls, and links to supporting evidence.
- [ ] Set up automated checks (“policy-as-code”) to confirm that compensating controls are equivalent and that overlay rules are followed, before publishing.
- [ ] Use tailoring inputs together with system design documents, data classification information, and evidence of risk and criticality to ensure accurate project scope and correct allocation of requirements.
- [ ] Create and review tailored lists of controls, map each requirement to the relevant system components, and extract the required contract terms from external provider agreements.
- [ ] Update the system security plan and privacy plan with version-controlled tailoring outputs, and obtain named approvals for both security and privacy.


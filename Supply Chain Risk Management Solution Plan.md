### SR-1 — Policy and Procedures (Control)

This requirement is about ensuring the organisation has clear, written rules for managing risks from suppliers, and that staff know exactly how to follow them. Without this, a weak or unreliable supplier could introduce harmful products, services, or ways of handling information. This could cause service disruption, financial loss, legal issues, or damage to trust.

To meet this expectation, the organisation must create, document, and publish an organisation-wide Supply Chain Risk Management policy, along with supporting procedures. The organisation must also appoint a Supply Chain Risk Management Officer to oversee the policy and procedures as they are developed, approved, and distributed.

The policy must explain its purpose, what it covers, the roles and responsibilities, the commitment from senior leadership, how different parts of the organisation work together, and how the organisation will check that the policy is being followed. It must also align with all relevant laws, directives, regulations, and internal guidance.

The policy must be reviewed and updated every year and within 60 days of any major trigger. The procedures must be reviewed and updated every year and within 30 days of any major trigger, including after supply chain assessment or audit findings, security incidents or breaches, or changes to relevant requirements.

##### Organisation-wide SCRM policy & procedures with SCRM Officer ownership

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain an organisation-wide **Supply Chain Risk Management (SCRM) policy** and **SCRM procedures** (not just a repeat of existing controls). These must cover the **SR** topic family and any supply-chain-related controls that are handled under other control families. Appoint an official **SCRM Officer** who is responsible for developing, documenting, and sharing these documents.

###### WHY (control requirement)
SR-1 requires **SCRM policy and procedures** that cover the **SR** topic family and relevant supply-chain-related controls. They must align with the organisation’s **risk management strategy** and be developed with **collaboration between the security and privacy programmes**.  
- The **policy** must be reviewed and updated **every year** and within **60 days** of any triggering event.  
- The **procedures** must be reviewed and updated **every year** and within **30 days** of any triggering event (for example: assessment or audit findings, security incidents or breaches, or changes to applicable requirements).

###### HOW (specific steps/approach)
1. **Appoint and document the SCRM Officer** as the named person responsible for developing, documenting, and sharing the SCRM policy and procedures.
2. **Create an organisation-wide SCRM policy** (the single source of truth) that includes: purpose; scope/coverage (SR topic family plus supply-chain-related controls handled elsewhere); roles and responsibilities; management commitment; how the security and privacy programmes will work together; and how compliance will be enforced and exceptions handled. Ensure it aligns with relevant laws, directives, regulations, and organisational standards.
3. **Create SCRM procedures** as practical guidance by role (for example: procurement officers, supplier/vendor management, security engineering, and system owners). Procedures must explain how the policy is put into practice across the supplier lifecycle (onboarding/intake, ongoing management, and change or exit/termination handling where relevant to your SCRM controls). They must also state what information must be provided and what records must be kept.
4. **Set up distribution lists and capture evidence**:  
   - Share the policy with **executive leadership, the Chief Information Security Officer (CISO), procurement leadership, and the SCRM Officer**.  
   - Share the procedures with **procurement officers, supplier/vendor management, security engineering, and system owners**.  
   Record evidence that the documents were shared and acknowledged.
5. **Use a trigger-based update process**: keep a change register that records triggering events (supply chain assessment or audit findings, security incidents or breaches, and changes to relevant requirements such as ITAR, Export Administration Regulations (EAR), HIPAA, GDPR, CMMC, NIS2, or other applicable requirements). This should automatically schedule policy updates within **60 days** and procedure updates within **30 days**.
6. **Run an annual review** with documented collaboration between security and privacy (for example, joint review meeting minutes and sign-offs), and publish updated versions using controlled document versioning.

###### WHO
- **SCRM Officer**: owns the development, documentation, controlled publication, and distribution of the policy and procedures.
- **CISO and Security Programme**: jointly develop and review the policy and procedures to ensure security alignment.
- **Privacy Programme**: jointly develop and review the policy and procedures to ensure privacy alignment.
- **Procurement Leadership / Supplier/Vendor Management**: provide operational input to the procedures and take part in annual reviews.
- **System Owners / Security Engineering**: confirm the procedures can be followed in practice and provide feedback.

###### Acceptance criteria
- An organisation-wide **SCRM policy document** exists, is controlled by version, has a named **SCRM Officer owner**, and clearly covers the **SR** topic family and relevant supply-chain-related controls handled elsewhere.
- An organisation-wide **SCRM procedures document** exists that provides role-based implementation steps (not just a repeat of controls) and includes required record-keeping.
- Evidence exists that the policy was shared with **executive leadership, the CISO, procurement leadership, and the SCRM Officer**, and that the procedures were shared with **procurement officers, supplier/vendor management, security engineering, and system owners**.
- Review and update timing can be demonstrated: the policy is reviewed/updated **annually** and within **60 days** of defined triggering events; the procedures are reviewed/updated **annually** and within **30 days** of defined triggering events.
- Collaboration between the security and privacy programmes is evidenced (for example, joint review and sign-off records).

###### Actions Required for Compliance

- [ ] Appoint a Supply Chain Risk Management (SCRM) Officer and formally record their responsibility for developing, documenting, and sharing the information.
- [ ] Draft and get approval for an organisation-wide supply chain risk management (SCRM) policy. The policy must clearly state its purpose, its scope (the “SR” family plus supply-chain-related controls that are handled in other documents), the roles and responsibilities for different teams, and how security and privacy teams coordinate their work.
- [ ] Develop supplier risk management (SCRM) procedures that set out role-based step-by-step implementation guidance and specify the required documents and records to keep (without repeating the control wording).
- [ ] Share the supply chain risk management (SCRM) policy with the executive leadership team, the chief information security officer (CISO), procurement leadership, and the SCRM Officer, and keep auditable proof that it was received.
- [ ] Share the supply chain risk management (SCRM) procedures with procurement officers, vendor management, security engineering, and system owners, and keep verifiable records showing that they received them.
- [ ] Set up a trigger register and a process to update the policy within 60 days, and to update the procedures within 30 days, after the defined triggering events occur.
- [ ] Carry out an annual joint security and privacy review, then publish updated documentation with version control and recorded approvals (sign-offs).


---

### SR-2 — Supply Chain Risk Management Plan (Control)

This requirement is about making sure the organisation has a clear, up-to-date plan for managing risks that arise from using outside suppliers and partners, covering the entire life of its systems. This includes everything from early development and design, through manufacturing, purchasing, delivery, combining with other parts, operating and maintaining, and finally disposing of the systems.

Without such a plan, harmful or counterfeit items could be introduced, products could be tampered with, poor practices could go unnoticed, or sensitive information about how the organisation works could be exposed. This could lead to service disruption, financial loss, or damage to trust.

The organisation is expected to create a supply chain risk management plan that covers all these stages. It must review and update the plan at least once every year and within 30 days of any major threat, organisational change, or environmental change. The plan must also be protected so that only authorised people can view it and only authorised people can change it.

##### Governed SCRM plan covering full lifecycle with protected updates

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain a system-level **Supply Chain Risk Management (SCRM) plan** that explains how the organisation will manage supply chain risks across the full lifecycle of relevant **systems, system parts, and system services**.

###### WHY (control requirement)
SR-2 requires an SCRM plan that:
- is specific to how the programme/system is implemented and fits the programme/system context,
- covers supply chain risk management activities, including **identifying and assessing risks, deciding how to respond to risks, creating response actions, and checking performance against the plan**,
- states the organisation’s **supply chain risk tolerance**, the acceptable **mitigation strategies/controls**, a **process for assessing and monitoring** supply chain risk, and **roles and responsibilities**,
- covers requirements for building **trusted, secure, privacy-protecting, and resilient** components/systems across the **software development lifecycle (SDLC)**,
- is **reviewed at least every year** and updated **within 30 days** of major changes in threats, the organisation, or the environment.

###### HOW (specific steps/approach)
1. **Create one “single source of truth” SCRM plan** in a controlled document repository, with required sections for each lifecycle area: **research and development (R&D), design, manufacturing, acquisition, delivery, integration, operations and maintenance, and disposal**.
2. **Set risk tolerance and mitigation strategies** in the plan (for example: acceptable levels of remaining risk, required assurance activities, and minimum supplier/security/privacy expectations).
3. **Link the process to the lifecycle**: connect each lifecycle section to the organisation’s acquisition/SDLC checkpoints (for example: supplier onboarding, security requirements checklists, release/change checkpoints, and decommissioning/exit activities).
4. **Define roles and responsibilities** in the plan using a **responsible, accountable, consulted, and informed (RACI)** model: plan owner, procurement owner, security/privacy reviewers, system owners, and any operational technology (OT) or engineering representatives where relevant; also state who approves accepting risk and who approves updates to the plan.
5. **Set up a “major change” trigger**: keep a register of threats/incidents/changes (supplier incidents, major threats, regulatory changes, and organisational/environmental changes) that automatically starts an SCRM plan impact assessment and update process, with a service-level agreement (SLA) to complete updates **within 30 days**.
6. **Control who can see and change the plan** using enterprise document controls: limit reading to named roles, allow edits only through an approval workflow, and use unchangeable versioning with audit records.

###### WHO (role responsible)
- **SCRM Plan Owner** (typically the Security Governance function / Chief Information Security Officer (CISO) office, or a delegated supply chain risk lead)
- **Procurement Lead** (ensures supplier onboarding and contract clause alignment)
- **Application/System Owner** (ensures system-level tailoring and lifecycle mapping)
- **Security and Privacy Reviewers** (check that mitigation strategies and trustworthy/resilient requirements are valid)
- **Document Control / Information Security** (ensures access control, document integrity, and auditability)

###### Acceptance criteria
- The organisation has an **approved SCRM plan** that clearly covers **all lifecycle areas** (R&D, design, manufacturing, acquisition, delivery, integration, operations and maintenance, disposal).
- The plan includes **risk tolerance**, acceptable **mitigation strategies/controls**, a **risk evaluation/monitoring process**, and **roles and responsibilities**.
- The plan is **reviewed at least annually**, and there is evidence of a process to update it **within 30 days** of major threat/organisational/environmental changes.
- The plan is stored in a controlled repository with **restricted access** and uses **approval-based change control** with **version history/audit trail**.
- The plan is used as part of (and linked to) acquisition/SDLC checkpoints (for example: supplier onboarding/security requirements checklist/release/change templates), so it is not treated as a standalone document.

###### Actions Required for Compliance

- [ ] Create a supply chain risk management (SCRM) plan template that includes mandatory sections for research and development (R&D), design, manufacturing, purchasing, delivery, integration, operations and maintenance, and disposal.
- [ ] Define the organisation’s acceptable level of supply chain risk and the mitigation strategies and controls that are allowed within the supply chain risk management (SCRM) plan.
- [ ] Create a mapping from the lifecycle stages to the software development lifecycle (SDLC) and procurement activities, and reference this mapping in supplier onboarding and in the security requirements approval checkpoints.
- [ ] Create a RACI (responsible, accountable, consulted, informed) in the plan that covers who is responsible and accountable for: plan ownership, procurement, security and privacy review, system ownership, and approval for risk acceptance and changes.
- [ ] Set up a process and tracking list for major changes, to review their impact and update the plan within 30 days.
- [ ] Store the supply chain risk management (SCRM) plan in a secure, controlled repository with restricted read access, approval-based permission to make changes, and an unchangeable version and audit history.


---

#### SR-2.1 — Establish SCRM Team (Enhancement)

This requirement is about setting up a dedicated team to identify and manage risks from suppliers and other external partners before they cause disruption. Without a clear team, important warning signs about suppliers, contracts, or the technology and services they provide can be missed. This can lead to delays, poor quality, legal issues, privacy breaches, or systems failing when they are needed most.

The organisation must appoint a **Supply Chain Risk Management** team, led and supported by the risk executive, the **Chief Information Security Officer** (CISO), a contracting officer, a supply chain or logistics lead, an IT lead, a privacy officer, legal counsel, a business continuity lead, and an acquisition lead. The team must lead and support the full process of:
- identifying, assessing, and prioritising supplier risks
- agreeing and defining practical actions to reduce those risks
- monitoring supplier performance over time
- making sure supply chain risks are considered during software development and when using third parties

The team must also communicate with internal and external stakeholders, and keep clear written records covering:
- roles and responsibilities
- the overall approach (strategy)
- procedures (including supply chain protection)
- implementation plans
- links to relevant security and privacy planning

These records must involve the appropriate functions, including acquisition, security, privacy, enterprise risk, legal, and business continuity responsibilities.

##### Establish chartered SCRM team with defined roles and activities

- Category: Manual
- Priority: Critical

###### WHAT
Set up a Supply Chain Risk Management (SCRM) team and formally approve its mandate so it can lead and support the organisation’s SCRM work.

###### WHY (control requirement)
SR-2(1) (enhancement) requires the organisation to **set up a supply chain risk management team** with the specified roles to **lead and support** the required SCRM activities: **identify, assess, and prioritise supplier risks; define how risks will be reduced; monitor supplier performance; manage software development life cycle (SDLC) and third-party dependencies; and communicate with stakeholders**.

###### HOW (specific steps/approach)
1. **Name the people who will hold each required role** on the team: risk executive, chief information security officer (CISO), contracting officer, supply chain/logistics lead, information technology (IT) lead, privacy officer, legal counsel, business continuity lead, and acquisition lead.
2. **Create and approve an SCRM charter** that sets out the team’s purpose, scope, decision-making authority (for example, accepting risk or escalating it), meeting frequency, and required outputs.
3. **Define the end-to-end SCRM process** the team will run: bringing suppliers into scope and grouping them, identifying risks, assessing and prioritising them, defining risk-reduction actions, setting contract control requirements, carrying out ongoing monitoring, and governing SDLC/third-party dependencies.
4. **Publish a responsibility matrix (RACI)** that links each SCRM activity to the required roles (showing who leads versus who supports) and explains how the team works with acquisition, legal, privacy, IT security, and business continuity.
5. **Build SCRM into SDLC and third-party dependency management** by setting required checkpoints (for example, third-party/component disclosure, security and privacy review gates, and evidence requirements) that the team will enforce through the organisation’s change and release governance.
6. **Set up stakeholder communication routes** for internal escalation and external engagement (for example, supplier risk questionnaires, coordinating remediation, and reporting supplier performance on a set schedule).

###### WHO
- **Risk executive** and **CISO**: jointly lead and own the SCRM programme, and chair the SCRM team.
- **Contracting officer** and **legal counsel**: own contract control requirements and the legal review process.
- **Supply chain/logistics lead** and **acquisition lead**: own supplier onboarding and supplier grouping inputs, and integrate SCRM into acquisition activities.
- **IT lead** and **privacy officer**: own governance for technical dependencies and privacy impact considerations.
- **Business continuity lead**: owns continuity implications and recovery-related supplier considerations.

###### Acceptance criteria
- A signed and approved **SCRM charter** exists and names all required role-holders.
- A documented **SCRM process** exists covering: identify/assess/prioritise, define risk-reduction actions, monitor performance, manage SDLC/third-party dependencies, and communicate with stakeholders.
- A **RACI** is published showing who is responsible for each SCRM activity across the required roles.
- Evidence is available that SCRM activities are **built into SDLC/third-party dependency governance** (for example, defined gates/checkpoints and required inputs/outputs).
- Procedures for stakeholder communication (internal escalation and supplier engagement) are documented with an agreed schedule.

###### Actions Required for Compliance

- [ ] Appoint named responsible people for the following roles: risk executive, chief information security officer (CISO), contracting officer, supply chain and logistics lead, information technology (IT) lead, privacy officer, legal counsel, business continuity lead, and acquisition lead.
- [ ] Approve and publish a supply chain risk management (SCRM) charter that sets out the scope, who can make decisions, how issues are escalated, how often meetings take place, and the required SCRM deliverables.
- [ ] Document the supplier risk management (SCRM) workflow, including: identifying, assessing and prioritising risks; defining and applying mitigations; monitoring supplier performance; managing software development lifecycle (SDLC) and third-party dependencies; and communicating with stakeholders.
- [ ] Create and publish a RACI matrix that maps each supply chain risk management (SCRM) activity to the required roles (lead or support) and the points of contact with procurement (acquisition), legal, privacy, information technology security, and business continuity.
- [ ] Define software development lifecycle (SDLC) and third-party dependency checkpoints—covering what information must be provided, the review steps (approval gates), and what proof must be kept—and ensure the supply chain risk management (SCRM) team enforces these requirements through the existing change and release governance process.
- [ ] Set up internal escalation and supplier engagement processes, including how risks are reported and assessed (risk intake), how information is collected from suppliers (questionnaires), how remediation work is coordinated, and how progress is monitored and reported on a regular schedule (monitoring and reporting cadence).


---

### SR-3 — Supply Chain Controls and Processes (Control)

This expectation is about making sure the organisations and suppliers you rely on to build, deliver, run, and maintain your on-site systems are properly checked, and that any issues are dealt with quickly. Without a clear, coordinated approach, a weak or dishonest supplier could introduce harmful software or hardware, or interfere with items during delivery, leaving your business exposed and unable to carry out its day-to-day work.

To meet this expectation, your organisation must set up a coordinated process, agreed with the supply chain risk lead and the system owner, to identify weaknesses in the supply chain and fix them. You must use supplier security reviews, checks that confirm where software and hardware came from and that it is genuine, and delivery requirements that make unauthorised interference obvious.

Finally, you must decide the specific steps you will use, put them in place, and record them in your supply chain risk management plan so the approach can be repeated and independently checked.

##### Risk-based supplier lifecycle with remediation and evidence gates

- Category: Manual
- Priority: Critical

###### WHAT
Set up a coordinated process to manage supply-chain risk for the on-premise information system and its parts. This process must: (1) find supply-chain weaknesses or gaps across the relevant supply-chain elements and activities, (2) fix the issues using agreed corrective actions and escalation, and (3) use supplier security checks, controls to confirm the trusted origin of software and hardware, and requirements for tamper-evident delivery. Choose the specific processes and controls you will use and record them in the supply chain risk management plan.

###### WHY (control requirement)
SR-3 requires that supply-chain elements and activities are protected by defined controls and processes that identify and address weaknesses or gaps. These controls and processes must be coordinated with supply chain risk management staff and the system owner. The guidance specifically includes supplier security checks, controls to confirm the trusted origin of software and hardware, and requirements for tamper-evident delivery. It also requires that the selected and implemented supply-chain processes and controls be documented (if selected) in the supply chain risk management plan.

###### HOW (specific steps/approach)
1. **Define scope and roles**: Confirm which system and components are in scope (the on-premise system and its components). Assign coordination responsibilities between the **supply chain risk management lead** and the **system owner**.
2. **Create a supplier/component map**: Keep an up-to-date inventory that links each in-scope system component (including third-party software libraries, firmware, hardware, and supplier/installer services) to its suppliers and delivery routes.
3. **Use risk-based supplier checks and repeat checks**: For each supplier, complete a supplier security assessment pack when they are onboarded and then repeat it on a defined schedule (for example, more frequent checks for higher-risk suppliers). Also repeat the assessment when major incidents occur, when significant vulnerabilities are found, or when contracts change.
4. **Set a clear fix-and-record workflow with proof**: If weaknesses are found, record them in a supply chain risk register. Assign an accountable owner, set due dates, and require evidence that the fix has been completed (for example, improved security measures, contract changes, replacement of components, or results from a new assessment). Escalate any unresolved risks to the system owner and the supply chain risk management lead.
5. **Apply procurement and delivery “go/no-go” checks**: Make sure procurement cannot proceed for in-scope suppliers unless there is an assessment result and the required risk acceptance (where applicable). When goods are received, check that tamper-evident delivery requirements were met and keep the inspection evidence.
6. **Document the selected processes/controls**: Record the full supply-chain risk process in the supply chain risk management plan, including how issues are identified, how fixes are managed, who coordinates what, what assessment evidence is kept, what triggers and schedule are used for repeat checks, and what is expected at receiving and for trusted origin.

###### WHO
- **Supply chain risk management lead**: Owns the supplier risk process, the assessment pack, the risk register, and escalation.
- **System owner**: Approves decisions to accept risk and confirms closure of fixes for findings that affect the system.
- **Procurement / vendor management**: Runs the supplier onboarding checks and ensures required controls are included in contracts.
- **Receiving/warehouse and engineering**: Performs tamper-evident receiving checks and provides evidence to the risk process.

###### Acceptance criteria
- A documented supply chain risk management plan exists and includes the selected identification and remediation processes/controls for the on-premise system and its components.
- The supplier inventory and the supplier-to-component mapping are complete for in-scope components.
- Supplier security assessments are completed for in-scope suppliers before procurement (or within an agreed remediation window) and are repeated according to the defined schedule and triggers.
- Any identified supply-chain weaknesses result in entries in the risk register, including an assigned owner, due date, remediation evidence, and documented closure approval by the system owner.
- Receiving processes verify that tamper-evident delivery requirements were met and keep inspection evidence so the process can be audited.

###### Actions Required for Compliance

- [ ] Identify the system components that are in scope and the supply chain roles involved in coordination, including the supply chain risk management lead and the system owner.
- [ ] Create and keep up to date a list of suppliers for each component used in the on-premises system and its components.
- [ ] Create a vendor security assessment pack and use it for every in-scope supplier when they are onboarded, and then repeat it on a defined schedule based on their risk level.
- [ ] Set up a supply chain risk register process to record risk findings, assign responsible owners, set target dates for fixes, and keep records of the evidence and the approvals needed to close each item.
- [ ] Put in place procurement checkpoints so that, before any order is placed with in-scope suppliers, a required assessment result (and any required approval to accept risk) is completed.
- [ ] Set up and carry out shipping receiving checks that make any tampering obvious, and keep the inspection records so the process can be reviewed during audits.
- [ ] In the supply chain risk management plan, document the chosen identification and remediation processes or controls, the events that trigger reassessment, the types of evidence to keep, and the escalation routes for concerns.


---

#### SR-3.1 — Diverse Supply Base (Enhancement)

This requirement is about not depending on just one supplier for the building blocks and support services your systems rely on. This matters because if a single supplier (including a developer or logistics provider) has an outage, goes out of business, is affected by a disaster, or their products are compromised, your organisation may struggle to replace critical components quickly. It could also be exposed through one weak link.

To meet this expectation, the organisation must use a range of sources for critical items such as hardware, firmware, operating system images, container base images, third-party libraries, and managed security services. This includes using more than one supplier for replacement parts and services, and ensuring that no single supplier or single location becomes a single point of failure for either service availability or security compromise.

The organisation should:
- document how it manages supply chain risk
- set acquisition and planning rules that require diverse sourcing
- keep records of what it uses and who provides it
- assign named responsibilities
- maintain a system security plan and related procedures that show how suppliers are identified and managed

##### Diverse sourcing for critical components and managed security services

- Category: Manual
- Priority: Critical

###### WHAT
Put in place a documented and enforceable approach to obtain the organisation-defined **system components and services** (critical hardware, firmware, operating system images, container base images, third-party libraries, and managed security services) from a **range of different sources**—so that no single supplier/provider (or single location) becomes a single point of failure for availability or for compromise.

###### WHY (control requirement)
SR-3(1) (Enhancement) requires: **“Employ a diverse set of sources for the following system components and services: {{ insert: param, sr-3.1_prm_1 }}.”** The guidance explains that using different sources lowers the chance of attackers successfully targeting the supply chain, and reduces the impact of supply chain incidents—because replacement components/services can stay available.

###### HOW (specific steps/approach)
1. **Create and maintain a Critical Supply Register** covering the exact items in `sr-3.1_prm_1` (critical hardware, firmware, OS images, container base images, third-party libraries, managed security services). For each item/service, record: supplier(s), contract(s), delivery/fulfilment location(s) (where applicable), and the intended use in the application lifecycle (development/testing/production/disaster recovery).
2. **Set diversity rules during purchasing planning**: update the organisation’s system/services acquisition and planning procedures so that for each critical item/service there are **at least two qualified sources** (and, where possible, two geography/fulfilment options). Record documented equivalence criteria (for example: operating system/container base version compatibility, library/application programming interface compatibility, firmware compatibility).
3. **Use supplier qualification and approval checkpoints**: require evidence-based qualification for each supplier/provider (for example: secure development practices, a vulnerability reporting process, and the ability to provide signed files/software bills of materials (SBOMs) where the organisation uses them). Make sure procurement processes cannot approve a critical item/service unless an approved alternate source is recorded in the Critical Supply Register.
4. **Put continuity and replacement terms into contracts**: for each critical supplier/provider, include contract clauses covering incident notification timeframes, delivery service level agreements (SLAs), substitution/right-to-replace terms, and evidence/audit rights—so replacements can be activated quickly during outages or suspected compromise.
5. **Keep a link between inventory and source**: ensure the application’s configuration and asset records (for example, configuration management database (CMDB) and deployment records) can be traced back to the supplier(s) used for: OS images/container base images, third-party libraries, and the managed security service provider(s). Keep this link up to date through change and release management.

###### WHO (role responsible)
- **Supply Chain/Procurement Lead**: owns the Critical Supply Register and the supplier qualification/contract continuity requirements.
- **Application Owner / Engineering Lead**: ensures deployment files and dependency records link to the approved supplier(s).
- **Information Security / Chief Information Security Officer (CISO) Office**: sets the evidence needed for qualification and reviews exceptions.
- **Change/Release Manager**: ensures the inventory-to-source link is updated during releases.

###### Acceptance criteria
- For every category listed in `sr-3.1_prm_1`, the Critical Supply Register shows **at least two approved sources** (supplier/provider) and recorded fulfilment location(s) where applicable.
- Procurement/approval records show that **no critical item/service** is approved without an **approved alternate source** recorded.
- Contracts for critical suppliers/providers include **continuity/replacement** and **incident notification** terms (as defined by the organisation).
- The application’s current deployment/configuration records can be traced to the **supplier(s)** used for OS images/container base images, third-party libraries, and the managed security service provider(s).
- Any exception (for example, single-source due to technical constraints) is documented with a risk explanation and compensating controls, and has a time-bound plan to achieve diversity.

###### Actions Required for Compliance

- [ ] Create a critical supply register for every item listed in `sr-3.1_prm_1`, and record the supplier or provider, the contract details, and the delivery/fulfilment location(s).
- [ ] Update the acquisition and planning procedures so that, for every critical item or service, at least two qualified suppliers or providers are used, and the reasons for treating them as equivalent are recorded using documented equivalence criteria.
- [ ] Set clear evidence requirements for qualifying suppliers, and use approval checkpoints to ensure critical purchases cannot go ahead unless there is an approved alternative supplier.
- [ ] Add contract clauses for continuity and substitution, and for incident notification, for each critical supplier or provider.
- [ ] Create and keep an up-to-date record that links what is currently deployed (operating system and container base images, third-party libraries) and the managed security services in use to the approved suppliers or providers.
- [ ] Define and document a time-limited exception process for any unavoidable case where there is only one source, including compensating controls.


---

#### SR-3.2 — Limitation of Harm (Enhancement)

This requirement is about making it harder for hostile outsiders to identify and take advantage of the organisation’s suppliers and delivery process. If we buy from unknown or unreliable sources, use unusual arrangements, or delay updates, an attacker could introduce a compromised product or service, or exploit weaknesses that have already been fixed elsewhere.

To reduce this risk, the organisation must:
- keep and use an approved list of permitted suppliers
- use standard arrangements for purchases and deployments rather than custom ones (unless there is a documented and authorised reason)
- follow agreed maintenance and update dates so fixes are applied as scheduled

The organisation must also:
- maintain a contingency plan for supply-chain disruptions
- use different delivery routes where feasible
- aim to minimise the time between deciding to purchase and receiving the goods or services

##### Procurement gate enforcing approved vendors and standard configs

- Category: Software
- Priority: Critical

###### WHAT
Set up a controlled procurement “gate” that only allows purchases to proceed when they use: (1) an approved vendor list, (2) standard configuration settings (or an authorised exception), and (3) a pre-agreed maintenance and patch schedule plus delivery lead-time commitments, recorded at the time of purchase. The gate must also ensure that procurement documents include supply-chain contingency and incident notification clauses.

###### WHY (control requirement)
SR-3(2) (Limitation of Harm) requires controls to limit harm if potential adversaries identify and target the organisation’s supply chain. The guidance specifically expects you to: avoid custom or non-standard configurations, use approved vendor lists, follow pre-agreed maintenance and update/patch delivery arrangements, keep a contingency plan for supply-chain events, and reduce the time between purchase decisions and delivery.

###### HOW (specific steps/approach)
1. **Create and maintain an approved vendor list** as the official supplier register (including legal entity identifiers, risk tier, approval status, and expiry). Add a **waiver/exception process** with clear approval authority and expiry dates.
2. **Define standard configuration baselines** for common acquisition categories relevant to the organisation’s environment (for example: reference cloud service configurations, hardened operating system/application images, approved database/storage/network service profiles, and vendor-supported reference architectures). Keep baseline versions and define what deviations are allowed.
3. **Add a procurement workflow gate** to the organisation’s procurement/enterprise resource planning (ERP) process so that requests cannot be turned into purchase orders unless the system records:
   - Approved vendor selection (or an active, approved waiver)
   - Selected standard configuration baseline version (or an approved deviation)
   - Committed maintenance and patch schedule (pre-agreed time windows and delivery method)
   - Expected delivery lead time and the chosen delivery route/provider
   - Contract or scope clauses covering supply-chain contingency/incident notification and cooperation requirements
4. **Use automated policy checks** (rules assessed automatically) to stop non-compliant requests, including: non-approved vendors, missing or expired waivers, missing baseline selection, missing maintenance/patch schedule commitments, and missing contingency/notification clauses.
5. **Record timing evidence from decision to delivery** by capturing the purchase decision date, order placement date, expected delivery date, and actual delivery date; highlight unusual delays for review to support reducing the time between purchase decisions and delivery.
6. **Store audit evidence** in the system of record, including: baseline template/version, waiver references, contract clause set identifiers, and maintenance/patch schedule commitments.

###### WHO (role responsible)
- **Procurement governance lead / Category manager**: owns the approved vendor list and waiver process.
- **Security architect / Chief Information Security Officer (CISO) office**: defines standardised configuration baselines and the automated policy checks.
- **Procurement system owner (ERP/IT service management (ITSM)/Procurement Operations)**: implements the workflow gate and evidence capture.
- **Legal/contract manager**: ensures contingency/incident notification clauses are included in templates.

###### Acceptance criteria
- A purchase order cannot be raised unless the vendor is on the approved vendor list or there is an active waiver.
- Standard configuration baselines are selected by default; any deviation must have an approved deviation record and be auditable.
- Every approved purchase record includes a committed maintenance and patch schedule and a defined delivery method.
- Every approved purchase record includes supply-chain contingency/incident notification clauses aligned to the organisation’s supply-chain contingency plan.
- The system records and can report decision-to-delivery lead times; unusual cases are flagged for review.
- Audit evidence can be retrieved for at least the last 12 months (or the organisation’s audit retention period).

###### Actions Required for Compliance

- [ ] Create and publish an official, approved supplier list that includes each supplier’s legal entity identifier, risk level (risk tier), and the date it expires.
- [ ] Set up version-controlled, standard configuration baselines for the relevant acquisition categories, and record any permitted exceptions (allowed deviations).
- [ ] Set up a procurement approval checkpoint in the enterprise resource planning (ERP) and procurement system that stops purchases from non-approved suppliers and prevents orders when required baseline selections are missing.
- [ ] Add “policy-as-code” rules to require maintenance and patch schedule commitments, and to include contract clauses for contingency and incident notification.
- [ ] Set up the gate to record the purchase decision date, the order placement date, the expected delivery date, and the delivery route and provider.
- [ ] Set up an exception or waiver process with clear approval steps and an expiry date, and make sure every waiver reference is recorded and stored with the purchase record.
- [ ] Store audit evidence for the baseline/version, waiver or exception IDs, contract clause identifiers, and patch schedule commitments.


---

#### SR-3.3 — Sub-tier Flow Down (Enhancement)

This requirement is about making sure the same supply-chain expectations you set for your main suppliers are also written into the contracts those suppliers use with their own subcontractors, all the way down the chain. Without this, a risk could enter through a lower-tier supplier that does not protect your services and information to the same standard. This could leave you exposed even if your top-level supplier contracts look compliant.

To meet this expectation, the organisation must:
- clearly identify which supply-chain risks and protection requirements it wants included;
- add a written obligation to every prime contractor contract requiring the prime contractor to include those exact requirements in every relevant subcontractor contract (including further sub-tiers);
- ensure the organisation’s procurement documents and templates clearly state this “flow-down” requirement.

The organisation must also involve the right people to define and check what must be passed on, keep acquisition records and service expectations consistent, and be able to provide evidence that both prime and subcontractor contracts actually include the required terms. Where any gaps are found, the organisation must follow them up until they are fully resolved.

##### Flow-down clause library and evidence annex for sub-tier contracts

- Category: Manual
- Priority: Critical

###### WHAT
Create an authoritative, clause-by-clause “flow-down clause library” and require it to be inserted into prime contractor contracts through a mandatory flow-down requirement and a “Subcontractor Flow-Down Evidence Annex”. The annex requires prime contractors to show that the same supply chain risk management control areas (the set of items to be flowed down) are included in all relevant subcontractor contracts and sub-tier subcontractor contracts.

###### WHY (control requirement)
SR-3(3) Enhancement requires that the controls included in prime contractor contracts are also included in subcontractor contracts. The guidance also requires flow-down beyond Tier 1, and it specifies that the control areas to be flowed down are identified in SR-3b.

###### HOW (specific steps/approach)
1. **Define the flow-down set**: produce a mapping document listing each SR-3b supply chain risk management control area that must be flowed down, and the exact clause/annex references that meet each area.
2. **Build a clause library**: create standard, contract-ready clause text (and, where needed, annex templates) covering each item in the flow-down set. This includes requirements that apply to system/component/service purchases and any related service level agreements (SLAs) and inter-organisational agreements used.
3. **Update prime contract templates**: add a mandatory contractual obligation requiring the prime contractor to (a) include the flow-down set in every relevant subcontractor contract, (b) ensure the obligation is passed to sub-tier subcontractors where applicable, and (c) use the specific clause library version set by the organisation.
4. **Add an evidence annex**: require each prime contractor to submit the “Subcontractor Flow-Down Evidence Annex” at contract award and whenever subcontract terms materially change. This must include (i) extracts of subcontract clauses/redacted copies, (ii) a checklist mapping each flow-down set item to confirm it is included, and (iii) confirmation of whether sub-tier flow-down applies.
5. **Enforce in procurement workflow**: configure procurement and contract lifecycle tools so contract approval cannot proceed unless the flow-down obligation clause and the evidence annex are included, and they reference the correct clause library version.
6. **Assign verification responsibility**: require security and supply chain risk representatives to sign off the flow-down set and the clause library version used for each procurement, to ensure the organisation’s security expectations are correctly reflected.

###### WHO
- **Supply Chain Risk Manager / Procurement Policy Owner**: owns the flow-down set mapping and clause library.
- **Information Security / Cybersecurity Lead**: checks that the clause wording correctly reflects the SR-3b control areas.
- **Commercial/Legal Contracting Team**: inserts the flow-down obligation and evidence annex into prime contract templates.
- **Contract Management / Vendor Management**: collects and reviews evidence annex submissions from prime contractors.

###### Acceptance criteria
- Prime contract templates include a clear flow-down obligation clause referencing the organisation’s flow-down clause library and requiring sub-tier flow-down where applicable.
- For each prime contractor, the organisation can demonstrate (using the submitted evidence annex) that subcontractor and sub-tier contracts include all flow-down set items, with no missing control areas.
- Procurement workflow blocks approval of prime contracts unless the flow-down obligation and evidence annex are present.
- Security and supply chain risk representatives sign off the clause library version used for each procurement.

###### Actions Required for Compliance

- [ ] Identify the control areas for SR-3b that make up the “flow-down” requirements, and document how each one maps to the relevant clause references.
- [ ] Create and maintain a library of clause-level “flow-down” clauses, with version control and contract-ready wording.
- [ ] Update the prime contractor contract templates to include a clear requirement to pass on the required terms to subcontractors and lower-tier subcontractors where applicable.
- [ ] Add a mandatory “Subcontractor Flow-Down Evidence Annex” that requires the relevant contract clause extracts (with any sensitive parts redacted) and a checklist showing how each requirement is covered.
- [ ] Set up the procurement and contract lifecycle workflow so that approvals are only granted when the flow-down obligation clause and the evidence annex are included.
- [ ] Set up a review and approval process so that, for each procurement, security and supply chain risk representatives check and sign off the required “flow-down” terms and the clause library version.


---

### SR-4 — Provenance (Control)

This requirement is about keeping a complete, reliable history for every on-premises system, software component, firmware, and approved starting configuration, and for any related Confidential and Secret information. The history must show where each item came from, who owned and controlled it, where it has been stored, and exactly what has changed over time. Without this, it is too easy for unauthorised or unexpected changes—such as from suppliers, upgrades, or internal mistakes—to go unnoticed. That makes it difficult to prove what happened, who was responsible, and whether the current setup is legitimate.  

To meet this expectation, the organisation must clearly define which items are covered, create a provenance record for each one, keep those records up to date as changes happen, and continuously monitor them for changes. It must also protect the provenance records from unauthorised edits, record who made any updates and the reason for them, and ensure the recorded history remains accurate and consistent, including when items are moved, ownership changes, or components are replaced.

##### Append-only provenance records for on-prem systems and data

- Category: Software
- Priority: Critical

###### WHAT must be done
Implement a provenance capability that **records, watches, and keeps provenance valid** for the organisation-defined scope: **all on-premises information systems, software components, firmware, configuration baseline settings, and the associated Confidential and Secret data**.

###### WHY (control requirement)
SR-4 requires the organisation to keep a **clear timeline of where things came from, how they were developed, who owns them, where they are located, and what has changed** for the covered systems/components/data. This also includes **the people and processes used to interact with or change them**, and it must **record and monitor provenance baselines and change records**. This ensures that changes (including supply-chain and configuration changes) can be traced and supports **non-repudiation**.

###### HOW (specific steps/approach)
1. **Define provenance scope and identifiers**: Create one authoritative inventory model that gives each covered item (system, component, firmware, configuration baseline) a stable identifier, and gives each associated Confidential/Secret dataset (or dataset type) that needs provenance a stable identifier.
2. **Create provenance baselines**: For each covered item, create an initial “valid provenance baseline” record at first deployment/approval. This must capture origin (supplier/developer), build/release identifiers, initial owner/custody, initial location/environment, and the configuration baseline reference.
3. **Record provenance change events**: Whenever a covered item or any provenance-relevant configuration changes, automatically record a provenance event that states: what changed, when, where (environment/location), by whom (a person identity or a system/workload identity), and the related change reference (for example, a change ticket/release ID) and process.
4. **Continuously monitor and reconcile**: Continuously collect information from change management, continuous integration/continuous delivery (CI/CD), configuration management, and asset lifecycle systems. Compare the “expected provenance state” with the “actually deployed state” (for example, the deployed version/configuration baseline) and flag any differences for investigation.
5. **Protect provenance records for non-repudiation**: Store provenance events in an **append-only, tamper-evident** store (for example, write-once, read-many (WORM) or immutable object storage) and **digitally sign** each event. Apply access controls so only authorised roles can add events, and require documented justification for any correction or closure actions.
6. **Provide audit-ready evidence**: Ensure provenance records and their integrity protections (signatures, immutability, access logs) are kept and can be searched for audit purposes, including the full history from origin to the current state.

###### WHO (role responsible)
- **Provenance/Configuration Manager** (owns provenance scope, baselines, and reconciliation rules)
- **Security Architect** (sets non-repudiation and tamper-evidence requirements)
- **Platform/DevOps Engineering Lead** (implements event collection from CI/CD/configuration/change systems)
- **Security information and event management (SIEM)/security operations centre (SOC) Operations** (monitors provenance mismatch alerts and supports investigations)

###### Acceptance criteria
- For every inventory item within the defined SR-4 scope, there is a **provenance baseline** record that includes origin, ownership/custody, and location/environment.
- For every approved change to a covered item or to a provenance-relevant configuration/data link, there is a corresponding **provenance change event** with a timestamp, the actor identity (person/system/workload), the change reference, and a before/after link to the configuration baseline identifiers.
- Provenance records are **append-only and tamper-evident**; each event can be verified using cryptographic checks, and writing provenance is restricted to authorised roles.
- The system continuously detects and reports **provenance state mismatches** (for example, the deployed version/configuration does not match the expected provenance baseline) with enough evidence to support audit and investigation.

###### Actions Required for Compliance

- [ ] Create an authoritative inventory that gives each covered system, component, firmware, and configuration baseline a stable identifier, and also assigns stable identifiers to each associated Confidential or Secret dataset (or dataset category).
- [ ] Define and implement a “provenance event” record format that covers: where the item came from, who currently owns or has custody of it, where it is located and the environment it is in, which approved configuration baseline it is linked to, and references to any changes made.
- [ ] Create and store baseline records showing the origin and history of all currently deployed covered items and datasets.
- [ ] Set up the system to collect provenance (origin) events from change management, continuous integration and continuous deployment (CI/CD), and configuration management, so that every approved change creates a signed provenance change event.
- [ ] Set up continuous checks to compare the expected source and history of data with what is actually deployed, and raise alerts when they do not match.
- [ ] Set up an append-only, tamper-evident record store that uses cryptographic signing and allows write access only for authorised roles.


---

#### SR-4.1 — Identity (Enhancement)

This expectation is about making sure the organisation can clearly identify everyone and everything involved in the supply chain behind its most important system parts, and keeping that information up to date. If the organisation cannot reliably identify all relevant suppliers, subcontractors, integrators, and the people and activities they carry out across research, building, delivery, installation, operation, maintenance, repair, and disposal, it becomes much harder to spot risky events and to investigate what went wrong after a change, suspected wrongdoing, or an incident.

To meet this, the organisation must:
- define the full scope of what needs identifying;
- give each organisation, process, and person involved a single, unique reference; and
- record enough information to support later investigation.

It must keep these records in an auditable register, update them whenever the supply chain changes or an incident occurs, clearly assign responsibility for maintaining them, and ensure this approach is built into purchasing and supply-chain protection planning, with documented plans for the system.

##### Authoritative supply-chain unique ID register for critical components

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain an auditable, authoritative record that uniquely identifies (with identifiers that are never reused) every supply-chain item, supply-chain activity, and supply-chain person linked to each critical system component throughout its full life cycle (research and development, manufacturing, acquisition, delivery, integration, operations, maintenance, disposal).

###### WHY (control requirement)
SR-4(1) enhancement requires the organisation to **set up and maintain unique identification** for the supply-chain items, activities, and people linked to the identified system and **critical system components** (SR-04.01_odp). The guidance also requires that the way identifiers are created and used is **good enough to support investigation** if there is a supply-chain change, compromise, or event.

###### HOW (specific steps/approach)
1. **Define the scope for each critical component**: For each critical system component, document which supply-chain items, activities, and people are in scope (including vendors, subcontractors, integrators, and their research and development, manufacturing, delivery, integration, operations, maintenance, and disposal activities) in line with **sr-04.01_odp**.
2. **Use one authoritative record** (a database or controlled document system) with a strict data structure:
   - `ElementID` for supply-chain organisations/entities/tools (unique, not reused)
   - `ProcessID` for supply-chain processes/activities (unique, not reused)
   - `PersonID` for individuals/roles involved (unique, not reused)
   - Linkage fields to investigation evidence: contract/SOW/PO references, change tickets, delivery/integration records, and disposal records.
3. **Record life-cycle status in an investigation-ready way**: For each entry, record `Active/Inactive` (or equivalent), `EffectiveFrom/EffectiveTo`, and link it to the supply-chain change event that triggered it (for example, supplier replacement, integrator change, key personnel change). Keep past information rather than overwriting it.
4. **Prevent duplicate identifiers and reuse**: Use database controls and governance rules so identifiers cannot be duplicated and are not reassigned after they are marked inactive.
5. **Update through formal change processes**: Make sure the record is updated as part of official supply-chain change management (for example, when a new subcontractor/integrator is approved, when a contract is amended, or when key personnel are replaced), so the record stays current.
6. **Assign named ownership and ensure auditability**: Assign responsibility for maintaining the record (for example, a Supply Chain Security/Procurement Security owner, with support from Engineering/Operations) and ensure it is version-controlled, access-controlled, and can produce audit-ready evidence.

###### WHO
- **Supply Chain Security / Procurement Security Lead**: owns the record, scope definition, and governance.
- **Procurement & Contracting**: provides contract/SOW/PO references and the triggers for changes.
- **Engineering/Operations/Service Delivery**: provides life-cycle activity links (integration, operations, maintenance, disposal references).
- **Information Security / Compliance**: checks completeness, audit readiness, and whether the evidence is sufficient.

###### Acceptance criteria
- For each critical system component, the organisation can produce an **audit-ready list** of all in-scope supply-chain items, activities, and people with **unique identifiers**.
- Identifiers are **not reused**, and the record keeps historical information with effective dates.
- Each identifier entry includes **links to evidence** sufficient to support investigation of a supply-chain change/compromise/event.
- The record is **kept up to date**: updates happen when supply-chain changes occur (new vendor/subcontractor/integrator, contract amendments, key personnel changes), with evidence that the update was made through the change workflow.

###### Actions Required for Compliance

- [ ] For each critical system component (per SR-04.01_ODP), define and document which supply-chain elements, processes, and people are included in scope.
- [ ] Design the official register data model, including: Element ID, Process ID, Person ID, links to supporting evidence, lifecycle status, and effective dates.
- [ ] Create the register and give every supply-chain element, process, and person within scope a unique identifier that is never reused.
- [ ] Put in place governance to keep a record of changes over time (using Active/Inactive status with EffectiveFrom and EffectiveTo dates) and to stop identifiers being reused.
- [ ] Add updates to supplier and supply-chain registers as part of change processes, including changes to vendors, subcontractors, integrators, and key personnel.
- [ ] Assign named ownership and ensure access controls are ready for audit, with version history and retained evidence for updates to the register.


---

#### SR-4.2 — Track and Trace (Enhancement)

This requirement is about making sure every important item used to build, move, and install a product can be uniquely identified and tracked from start to finish. Without this, it is hard to prove where a specific hardware part, firmware update, or software build came from, whether it was changed while being transported, or which exact version was deployed. That makes it more difficult to limit the impact of problems and to investigate supply-chain issues after something goes wrong.

To meet this expectation, the organisation must:
- Clearly define which systems and critical components are in scope.
- Give each in-scope item a unique identifier and record the link between the identifier and the item.
- Keep those identifiers accurate and unchanged as items move through development, transport, and deployment, while allowing more than one identifier when needed.
- Maintain complete records of the full trail, ensuring they are detailed enough to support investigations.

The organisation must also ensure there is clear ownership, documented processes, and that the right requirements are included in purchasing and planning documents.

##### Authoritative IDs and provenance records for in-scope artefacts

- Category: Software
- Priority: Critical

###### WHAT
Set up and keep a unique identification for all **systems and critical system components** in scope (including **hardware, firmware, and software build artefacts**) so they can be tracked through the supply chain. Keep records detailed enough to support forensic investigation after a supply-chain compromise.

###### WHY (control requirement)
SR-4(2) enhancement requires the organisation to **“set up and keep unique identification”** for the defined scope (**sr-04.02_odp: systems and critical system components**). This is to support **tracking during development and transport activities** and to enable **provenance** and **forensic investigation**.

###### HOW (specific approach)
Create an authoritative “identity and provenance record” capability that links each in-scope item to one or more unique identifiers and to the events that move it through the supply chain.

1. **Define the in-scope item model** aligned to sr-04.02_odp: include hardware units, firmware packages, and software build artefacts (for example, installers, packages, and container images). Identify which sub-components are “critical” for tracking.
2. **Create an identifier structure** for each item type that allows multiple identifiers per item (for example, serial number plus RFID tag; firmware package ID plus version; build ID plus an unchangeable artefact hash/digest; part number plus revision). Apply rules for identifier format and enforce uniqueness.
3. **Record unchangeable provenance events** and link them to identifiers: build (continuous integration/continuous delivery (CI/CD) run ID, code commit, pipeline), testing and validation, packaging, handover to logistics, shipment, receipt, and deployment. Store the identifier-to-item mapping and the full event timeline in a controlled, searchable store.
4. **Automate data capture** from the application delivery process and logistics:
   - CI/CD produces a build ID and artefact hash/digest.
   - The artefact repository/container registry provides unchangeable digests and metadata.
   - Release and configuration tools record which build artefact was deployed to which environment.
   - Warehouse and receiving teams scan physical identifiers (barcode/RFID) and record shipment and receipt events.
5. **Enforce traceability at deployment time**: require deployment requests to reference the recorded build artefact identifier(s), and confirm the artefact hash/digest matches the recorded value. Stop or flag deployments where the required mappings are missing or inconsistent.
6. **Keep and protect records for forensic readiness**: apply access controls, integrity protections (for example, append-only or signed event records), and retention periods aligned to organisational policy, so records remain usable after a supply-chain event.

###### WHO
- **Application/Release Engineering Lead**: defines the identifier structure and integrates CI/CD and release tooling.
- **Configuration/Configuration Management Database (CMDB)/Asset Data Owner**: owns the authoritative provenance record model and ensures data quality.
- **Security/Compliance Lead**: checks that records are sufficient for forensic needs, retention requirements, and audit evidence.
- **Logistics/Warehouse Operations**: ensures physical identifier scanning and shipment/receipt capture.

###### Acceptance criteria
- For every in-scope item (per sr-04.02_odp), the system can produce a **complete identifier-to-item mapping** and **end-to-end event timeline** from build/packaging through shipment/receipt to deployment.
- Each item has **unique identifier(s)** recorded, and the system supports **more than one identifier per item**.
- Deployment is allowed only when the referenced identifiers exist and the **artefact hash/digest matches** the recorded provenance record (or an auditable exception process exists).
- Provenance records are **tamper-evident/unchangeable or integrity-protected**, access-controlled, and retained so they remain available for forensic investigation.

###### Actions Required for Compliance

- [ ] Define the scope categories for sr-04.02_odp (hardware, firmware, software build outputs, and critical sub-components) and document the rules for what must be included.
- [ ] Create and publish an identifier system for each item type that allows each item to have multiple identifiers, while enforcing that identifiers are unique and follow the required format rules.
- [ ] Set up a trusted provenance record system that links each identifier to the related item and to the relevant supply-chain events, including building, packaging, shipment, receipt, and deployment.
- [ ] Integrate continuous integration and continuous delivery (CI/CD) with artefact repositories and registries to automatically record build identifiers and create tamper-proof artefact hashes or digests in the provenance records.
- [ ] Integrate logistics and warehouse scanning (barcode and radio-frequency identification (RFID)) to record physical identifier scans and link shipment and receipt events to the same provenance records.
- [ ] Add a check at deployment time to confirm that the recorded identifier mappings are present and that the artefact’s hash or digest matches. Only then allow the deployment; otherwise raise an auditable exception.
- [ ] Set how long provenance records are kept, who can access them, and add tamper-evident or integrity protections so they remain usable for forensic investigations.


---

#### SR-4.3 — Validate as Genuine and Not Altered (Enhancement)

This requirement is about making sure every computer part or software package you receive is genuinely from the correct supplier and has not been secretly altered. Without these checks, a counterfeit or tampered item could be installed, which could give criminals a hidden way to interfere with your systems, steal information, or disrupt services—sometimes without any obvious warning.

To meet this expectation, the organisation must set out and follow documented steps for acceptance testing before anything is used. This includes:
- obtaining and reviewing evidence from the supplier showing who handled the item and when
- checking that the software and firmware match the expected integrity checks (mathematical verification)
- confirming hardware authenticity using tamper-evident measures, such as anti-tamper labels
- carrying out visual inspections and additional physical tests that can reveal signs of interference

The organisation must also:
- monitor for performance that is outside the stated specification
- treat any suspicious results as grounds to quarantine the item
- arrange replacement
- where needed, commission a forensic investigation to identify the source

Finally, the organisation must keep records of all checks, include these validation expectations in purchasing documents and contracts, assign named responsibilities, and train relevant staff to recognise suspicious deliveries.

##### Acceptance gate for genuine, unaltered firmware/binaries

- Category: Software
- Priority: Critical

###### WHAT
Set up an auditable “acceptance gate” for every system component and every software/firmware package received. This gate must check, before the item is allowed into any environment, that: (1) the item’s cryptographic integrity is correct (hashes and/or digital signatures), (2) there is evidence of supplier custody and handling, and (3) there are signs the item has not been tampered with (for example, anti-tamper seals/labels).

###### WHY (control requirement)
SR-4(3) enhancement requires the organisation to “validate that the system or system component received is genuine and has not been altered” using organisation-defined controls ({{ insert: param, sr-4.3_prm_1 }}). This includes cryptographic hash and/or digital signature checks, hardware authenticity checks using physical authenticity methods (for example, physically unclonable functions (PUF) and anti-tamper labels), side-channel or optical checks, and supplier custody evidence.

###### HOW (specific steps/approach)
1. **Define an acceptance validation procedure** for receiving and installing components/images. This procedure must specify the required evidence fields, including: asset identifier/serial, supplier, lot/batch, delivery date/time, seal/label condition, integrity check results, operator, and where the evidence is stored.
2. **Set up a trusted approach for integrity verification**: keep a register of vendor signing keys/certificates (public keys/certificates) and use a method to confirm signed documents or the expected hashes provided by the supplier/original equipment manufacturer (OEM).
3. **Automate integrity checks when items are received**:
   - For firmware/binaries, pull the relevant files from the received media/device or installation package.
   - Check **digital signatures** against the trusted key register. If digital signatures are not available, check **cryptographic hashes** against supplier-provided signed documents or expected hash lists.
   - Store the results (pass/fail, algorithm, hash/signature identifiers, and timestamps) as permanent, unchangeable evidence.
4. **Check tamper-evidence and supplier custody**:
   - Require supplier custody attestation (for example, supplier portal attestation, courier scan events, seal/label identifiers) and store it with the acceptance record.
   - Inspect anti-tamper seals/labels before accepting the item; take photos and record seal/label identifiers and condition.
   - If the component supports it, confirm hardware authenticity using **physically unclonable functions (PUF)**. If it does not, document the alternative control as anti-tamper seal/label verification.
5. **Apply a quarantine/replace decision rule**:
   - If any integrity check or tamper-evidence/custody check fails, stop provisioning/deployment, quarantine the item, and start supplier/OEM replacement or forensic investigation.
   - If agreed performance indicators are available for the component, run the agreed performance checks and treat failures as possible signs of tampering or counterfeit items.
6. **Build this into the release/deployment process**:
   - Add a policy gate in the continuous integration/continuous delivery (CI/CD) or release pipeline so deployment cannot continue unless the acceptance gate evidence shows success.

###### WHO (role responsible)
- **Security Engineering / Application Security (AppSec) & Platform Security**: define the acceptance validation procedure, the trusted integrity approach, and the evidence requirements.
- **Infrastructure/Platform Engineering**: implement the automated integrity verification and quarantine workflow.
- **Asset/Configuration Management (CMDB) Owner**: ensure evidence is linked to the correct asset record.
- **Procurement / Supplier Management**: ensure supplier custody attestation requirements are included in purchase orders/contracts.
- **Operators/Release Managers**: carry out receipt checks (including seal/label inspection) and confirm the evidence is complete.

###### Acceptance criteria
- For 100% of received firmware/binary packages, the acceptance gate produces an auditable record showing the results of signature/hash checks and the status of supplier custody attestation.
- Deployment/provisioning is blocked if signature/hash verification fails, or if tamper-evidence/custody attestation is missing or suggests possible tampering.
- Evidence (integrity results, seal/label photos/identifiers, and custody attestation) is kept and linked to the relevant asset/component record for audit purposes.
- Where physically unclonable functions (PUF) are supported by the hardware, authenticity is validated using physically unclonable functions (PUF). Where not supported, anti-tamper seal/label verification is carried out and documented as the alternative approach.

###### Actions Required for Compliance

- [ ] Create an acceptance validation process that sets out the required proof, the rules for passing or failing, and the conditions that trigger quarantine.
- [ ] Maintain a trusted register of vendor signing keys and certificates, and a process to check that signed manifests (or expected file hashes) are valid.
- [ ] Set up an automated integrity check for received firmware and software files (preferably by verifying their digital signature; use file hash checks if signatures are not available) and store unchangeable proof of the results.
- [ ] For every received component or image, require the supplier’s chain-of-custody attestation and review it before you accept the item.
- [ ] Carry out and record an inspection of anti-tamper seals and labels (including taking photos and recording the seal or label identification numbers) before setting up the equipment for use.
- [ ] Add a continuous integration and continuous delivery (CI/CD) or release pipeline “gate” that blocks deployment unless the acceptance gate evidence shows the release was successful.
- [ ] Set up and run a “quarantine and replace” process, with an escalation to forensic investigation, whenever any check fails.


---

#### SR-4.4 — Supply Chain Integrity — Pedigree (Enhancement)

This requirement is about making sure the most important technology and services you buy are exactly what the supplier says they are—right down to what they are made of and where they came from. Without this check, a harmful or changed item could be accepted—for example, software that contains unexpected parts, hardware built from different components, or firmware that does not match the equipment delivered. This could lead to fraud, disruption, or a loss of trust in critical operations.

To meet this expectation, the organisation must first decide which items are classed as critical or mission-essential. It must then require suppliers to provide proof of origin and make-up before anything is accepted. This includes records of the software parts and their versions, a list of components, manufacturer details such as serial numbers and hardware component lists, and unique identifiers that match the actual delivered hardware. The organisation must check these records against what is being supplied, confirm what the item is made of and where it came from, use the results to accept or reject the item, and keep clear records of acquisition and planning showing who checked what and when.

##### Pedigree acceptance gate for critical components and software

- Category: Software
- Priority: Critical

###### WHAT
Set up an evidence-based “pedigree acceptance gate” for all technologies, products, and services that the organisation defines as critical or mission-essential. Before any item is accepted into any environment, the gate must check what the item is made of and where it came from, using evidence provided by the supplier (for example, software identification/component lists, manufacturer statements, and firmware or hardware checksums).

###### WHY (control requirement)
NIST SR-4(4) enhancement requires using **controls** and an **analysis method** to protect integrity by checking the **internal make-up** and **origin** of **critical or mission-essential** technologies, products, and services. The guidance calls this check “pedigree”. For software, it includes the **make-up of open-source and proprietary code** and the **version of each component at a specific point in time**. It also notes that evidence can include **SWID tags (software identification tags)**, **software component inventory**, **manufacturer declarations** (for example, serial numbers and hardware component lists), and **measurements such as firmware checksums that are tightly linked to the hardware**.

###### HOW (specific steps/approach)
1. **Define scope and evidence requirements**: Maintain a list of in-scope items (by stock keeping unit/configuration and criticality level). For each level, specify which pedigree evidence is required (for example, SWID/software component list plus component versions for software; platform details and serials plus component inventory for hardware; and firmware/hardware checksum records for firmware packages).
2. **Standardise pedigree evidence format**: Define a standard evidence format that, at minimum, includes identifiers that link the evidence to the delivered unit (for example, serial number/asset tag, platform identifiers, build identifiers) and the supporting evidence (SWID XML or equivalent, component inventory/software component list with versions, manufacturer declarations, and checksum values including the algorithm and date/time).
3. **Build acceptance gating into procurement/receiving**: Update procurement documents, supplier onboarding checklists, and receiving procedures so that no in-scope item is accepted unless the required pedigree evidence is provided and passes the checks.
4. **Run automated checks and comparisons**: In an evidence intake process, read and standardise supplier evidence (SWID/software component list, manufacturer declarations, checksum records). Then compare it against the organisation’s expected bill of materials (BoM) for the specific stock keeping unit/configuration. Flag any differences (unexpected components, unauthorised versions, missing components, or evidence that cannot be linked to the intended unit).
5. **Check checksums where possible and enforce linking**: For delivered items where checksums can be calculated (for example, signed installers, container images, firmware packages), calculate checksums and compare them to the supplier’s stated values. Where direct calculation is not possible, require supplier evidence that explicitly references the delivered unit identifiers (for example, serial/asset tag). Reject evidence that is generic or not linked to the specific unit.
6. **Record outcomes and control decisions**: Use a workflow that records who performed the validation, when it was done, which evidence set was used, the analysis results, and the accept/reject decision. Send exceptions to supply chain risk management for resolution and require documented compensating actions if any acceptance happens despite mismatches.

###### WHO (role responsible)
- **Supply Chain Risk Manager / Procurement Lead**: owns the in-scope item list, supplier requirements, and the acceptance gate within procurement/receiving.
- **Information Security / Application Security Lead**: owns the pedigree evidence standard and the analysis rules for software make-up and origin.
- **Asset/Configuration Manager or Infrastructure Engineering Lead**: provides the expected bill of materials mappings and ensures unit identifiers are available for linking.
- **Receiving/Operations Team**: carries out the acceptance gate checks (or triggers the automated workflow) and keeps the audit records.

###### Acceptance criteria
- For every organisation-defined in-scope purchase, the system cannot be accepted into any environment unless the required pedigree evidence is present and validated.
- Evidence validation includes (as applicable to the item type) SWID/software component inventory with component versions, manufacturer declarations with platform attributes/serials, and checksum verification or checksum evidence that is linked to the specific unit.
- Validation results (pass/fail), evidence references, analysis outputs, and the accept/reject decision are kept as auditable records.
- Any mismatch must lead to rejection, or to a documented, risk-assessed exception process approved by supply chain risk management.

###### Actions Required for Compliance

- [ ] Create and get approval for an in-scope catalogue of critical, mission-essential items. For each item type, include the required supporting evidence (pedigree artefacts).
- [ ] Define a pedigree evidence format that requires unit identifiers (for example, serial numbers or platform identifiers) plus software identification (SWID) and software bill of materials (SBOM), component version details, and hash lists where applicable.
- [ ] Update the procurement and receiving templates so that pedigree evidence is a required acceptance deliverable for all in-scope purchases.
- [ ] Set up an evidence intake and standardisation process to read and convert software identification (SWID) component inventories, software bill of materials (SBOM) files, and manufacturer declarations into a consistent format.
- [ ] Set up automated checks to compare the supplier’s evidence against the expected bill of materials (BoM) for the specific stock keeping unit (SKU) and configuration, and report any differences.
- [ ] Verify the hash (digital fingerprint) for delivered, accessible artefacts, and reject them if the hash evidence is not tied to the specific unit.
- [ ] Record the validation results, the sources of supporting evidence, and the accept or reject decision in an auditable workflow. If there is an exception, route it to supply chain risk management.


---

### SR-5 — Acquisition Strategies, Tools, and Methods (Control)

This requirement is about buying technology in a way that makes it much harder for the wrong or harmful parts to be introduced. If the organisation does not use trusted delivery routes, tamper-evident packaging, and restricted purchasing channels, a supplier could replace items, steal or alter components, or deliver counterfeit or contaminated parts. The organisation could also end up with products built using poor practices.  

To meet this expectation, for every system, component, or service the organisation buys, it must: use trusted or controlled distribution; require tamper-evident packaging; and use restricted purchasing where applicable. It must also put clear contract terms in place that ban counterfeit or tainted components and require supply-chain transparency.  

The organisation must have documented policies, procedures, and a plan for managing supply-chain risk during acquisitions. It must follow its documented acquisition process and steps that include these protection needs, include the requirements in requests for proposals and purchase records, and reflect them in service agreements where relevant. It must keep evidence that relevant staff have been trained, assign named responsibilities, and use supply-chain risk assessments to select and tailor the buying approach to prevent, detect, and reduce these risks.

##### Risk-tiered procurement guardrails for trusted, tamper-evident supply

- Category: Software
- Priority: Critical

###### WHAT
Set up a controlled procurement process that applies **sourcing approaches, contract requirements, and purchasing methods** to every relevant purchase. Use a **supply chain risk assessment** to decide which protections to apply.

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **SR-5** requires the organisation to use **sourcing approaches, contract requirements, and purchasing methods** to **protect against, identify, and reduce supply chain risks** (based on the organisation-defined parameter **sr-05_odp: strategies, tools, and methods**). The guidance specifically highlights using **trusted and controlled distribution**, **tamper-evident packaging**, **filtered purchasing where applicable**, and contract wording that **bans tainted or counterfeit parts** and **requires supply-chain transparency**.

###### HOW (specific steps/approach)
1. **Create a supply chain risk tiering model** for purchases (for example: information technology (IT) hardware, security appliances, components near operational technology (OT), managed services, software/licences, and critical spare parts). For each tier, set the required SR-5 protections in line with **sr-05_odp** (trusted and controlled distribution, tamper-evident packaging, filtered purchasing where applicable, and contract clauses that prohibit counterfeit/tainted items and require transparency).
2. **Build policy controls into the procurement workflow** (enterprise resource planning (ERP) or procurement system) so that purchase requests and purchase orders cannot be approved unless the correct SR-5 clause set and purchasing constraints are selected based on the risk tier.
   - Enforce **trusted and controlled distribution** by limiting supplier and distributor choices to an approved list.
   - Enforce **tamper-evident packaging** by requiring packaging requirements to be stated on the purchase order and/or solicitation.
   - Enforce **filtered purchasing where applicable** by limiting ordering to approved channels and controlled ordering routes.
3. **Use contract templates that include mandatory SR-5 clauses** for all relevant purchases:
   - A clause that prohibits **tainted or counterfeit components**.
   - A clause that requires **supply-chain transparency** (for example: evidence of sourcing, origin, and traceability, and disclosure of subcontracting and, where relevant, where items come from).
   - For services, include expectations for subcontractors and the supply chain, plus evidence requirements appropriate to the risk tier.
4. **Require and attach supply chain risk assessment evidence** to the purchase request for higher-risk tiers (and, at minimum, record the selected tier and the reason for all tiers). Make sure solicitation documents and purchase records capture the selected sourcing approaches, tools, and methods.
5. **Assign named roles and approval steps** (for example: a Procurement owner plus a Security/Supply Chain risk approver). Ensure the workflow records who approved what, when, and which clause set was applied.

###### WHO (role responsible)
- **Procurement Lead / Category Manager**: owns approved supplier and distributor lists, controls for filtered purchasing channels, and governance of contract templates.
- **Supply Chain Risk Owner (Security / Third-Party Risk)**: owns the risk tiering model and the rules for selecting clauses.
- **System/Platform Owner for the Procurement Workflow (IT)**: implements the policy controls and audit logging.
- **Security Approver**: checks the risk tiering and clause selection for higher-risk purchases.

###### Acceptance criteria
- For each purchase covered by SR-5, the procurement record (purchase request, purchase order, and contract) must include:
  - the **risk tier** based on the supply chain risk assessment,
  - evidence that **trusted and controlled distribution** and **tamper-evident packaging** requirements were applied (where those requirements apply to the tier and item),
  - evidence that **filtered purchasing** was applied where applicable,
  - contract wording that includes **prohibitions on counterfeit/tainted items** and **requirements for supply-chain transparency**.
- The policy controls prevent approval when required SR-5 fields or clauses are missing for the selected risk tier.
- Audit logs show the approver’s identity, date and time, the selected clause set, and attached supply chain risk assessment evidence for higher-risk tiers.

###### Actions Required for Compliance

- [ ] Define a supply chain risk ranking model for acquisitions and assign each risk level the required SR-5 protections from `sr-05_odp`.
- [ ] Set up procurement workflow rules (automatically enforced by code) to allow only approved, trusted suppliers and distributors, using a risk tier to decide which ones are permitted.
- [ ] Require tamper-evident packaging details on purchase orders and requests for proposals, and prevent approval when those details are missing for the relevant supplier tiers.
- [ ] Where relevant, enforce filtered-buy constraints by limiting ordering channels or paths to approved routes.
- [ ] Update contract templates to include mandatory clauses that (1) prohibit tainted or counterfeit components and (2) require proof of supply-chain transparency.
- [ ] Add the results of supply chain risk assessments to purchase requisition records, and require supporting evidence to be attached for suppliers in higher-risk tiers.
- [ ] Assign named procurement and security approvers, and ensure audit logs record the chosen service tier, the selected contract clause set, and the approval decisions.


---

#### SR-5.1 — Adequate Supply (Enhancement)

This requirement is about making sure the organisation can keep its industrial control equipment working even when deliveries are disrupted or parts fail. It matters because, if key items such as controllers, programmable logic controllers, safety relays, network switches, power supplies, or critical sensors and actuators cannot be obtained in time, operations could stop, safety could be put at risk, and repairs could be delayed.

To meet this expectation, the organisation must:
- keep an up-to-date list of which components are critical;
- decide what “enough supply” means for each critical component; and
- set clear targets for how much stock is needed and for how long it must be available during mission-critical periods.

The organisation must also:
- obtain these critical components from more than one supplier across the supply chain;
- hold spare parts for the agreed mission-critical time periods; and
- identify substitute parts that are functionally identical or similar, which can be used if the original item is not available, including the conditions for using them.

##### Adequate supply register with multi-sourcing, mission spares, and approved substitutes

- Category: Manual
- Priority: Critical

###### WHAT
Set up and keep an auditable **“adequate supply” programme** for the organisation’s **critical system components** (for example: industrial control system controllers/programming logic controllers (PLCs), safety relays, network switches, power supplies, and critical sensors/actuators). The programme must:
- define what **“adequate supply”** means for each component
- ensure **more than one supplier** is available across the supply chain
- keep **spare parts held in reserve** for mission-critical periods
- document **approved replacement parts that are functionally identical or similar**, including the conditions under which they may be used

###### WHY (control requirement)
SR-5(1) (Enhancement) requires controls to ensure an **adequate supply of the identified critical system components**. Guidance highlights the risk of an attacker disrupting supply and expects controls such as:
- **multiple suppliers**
- **holding spare parts in reserve** for mission-critical times
- **identifying replacement parts** that are functionally identical or similar for use when needed

###### HOW (specific steps/approach)
1. **Create a Critical Components Register** (using a configuration management database (CMDB)/asset system or a controlled governance, risk, and compliance (GRC) repository). It must include, at minimum: the component identity, its purpose, compatibility limits, how critical it is, and the approved alternatives/replacements.
2. **Set “adequate supply” targets** for each component using measurable criteria linked to keeping operations running (for example: the required number of items on hand and how long they cover mission-critical periods). Record what counts as the mission-critical period (for example: the outage/recovery time window) and the reason for the target.
3. **Put multi-sourcing in place**: for each critical component, record at least two approved ways to source it from qualified suppliers across the supply chain (including approved purchasing routes), and document the qualification status.
4. **Maintain mission-critical spares**: set minimum quantities to hold and reorder points for each critical component. Define storage and handling rules, and run a regular check to confirm the spares are still fit for use.
5. **Document replacement options**: identify functionally identical or similar components that can be used if the original is not available, and define the conditions and limits for replacement (for example: electrical/firmware compatibility, safety certification limits, configuration requirements, and any required engineering checks).
6. **Build this into procurement and change processes**: ensure purchase requests/contracts for critical components refer to the register entry, the required spare parts targets, the selected suppliers, and the replacement rules. Keep evidence for audit purposes.

###### WHO (role responsible)
- **Operational Technology (OT)/Engineering Asset Owner**: defines component criticality, mission-critical periods, and replacement compatibility limits.
- **Procurement/Supply Chain Manager**: qualifies and maintains multi-supplier sourcing routes and keeps contract evidence.
- **Reliability/Operations Lead**: sets spare parts quantities, storage and verification timing, and checks that spares remain usable.
- **Governance, Risk, and Compliance (GRC)/Compliance Lead**: ensures the programme is documented, version-controlled, and ready for audit.

###### Acceptance criteria
- A maintained **Critical Components Register** exists and includes all components listed under the organisation-defined **critical system components** parameter.
- For each critical component, the organisation can show:
  - (a) **adequate supply targets** (measurable spare parts coverage for mission-critical periods)
  - (b) **multi-sourcing** (multiple suppliers across the supply chain)
  - (c) **mission-critical spares** with current quantities on hand and verification evidence
  - (d) **approved replacements** with documented conditions/limits
- Procurement records show that decisions to buy critical components reference the register and the adequate-supply requirements, with evidence retained that is suitable for audit.

###### Actions Required for Compliance

- [ ] Create and keep a **Critical Components Register** that lists every item in **sr-05.01_odp.02**, including its level of criticality, any compatibility limits, and the approved alternative options.
- [ ] Set measurable “adequate supply” targets for each critical component, including how long mission-critical coverage must last and the reason for choosing each target.
- [ ] For each critical component in the register, identify and record multiple approved suppliers and sourcing routes across the supply chain.
- [ ] Set and manage the required stock levels for mission-critical spare parts (the minimum amount to keep on hand and the point at which to reorder), and carry out regular checks to confirm the parts are still fit for use, with supporting evidence.
- [ ] Document any functionally identical or similar substitute items, and clearly state the conditions and limits for using them (including any engineering validation requirements).
- [ ] Update the procurement and contracting templates, and the purchase requisition templates, to refer to the register entries, spare parts targets, supplier selections, and substitution rules.


---

#### SR-5.2 — Assessments Prior to Selection, Acceptance, Modification, or Update (Enhancement)

This expectation is about making sure that anything new you bring into your organisation—software, hardware, services, or updates—is checked first, before you commit to it. It addresses the risk that a supplier item or change could be altered, include harmful hidden behaviour, be defective, or be a fake product, and that weaknesses could go unnoticed. This could lead to disruption, loss of data, or unauthorised access.

To meet this requirement, the organisation must carry out suitable security checks and inspections before choosing, accepting, changing, or updating the item. The checks must be appropriate to what it is, and must specifically look for signs of tampering, malicious behaviour, hidden ways to access systems, unintentional or deliberate weaknesses, defective or counterfeit items, and any failure to follow supply-chain protection expectations.

The organisation must record the results and keep the evidence so decisions and follow-up actions can be taken. It must also ensure the right internal roles (and independent external assessors where needed) carry out the work and document it.

##### Security assessment gate for app/service selection and updates

- Category: Software
- Priority: Critical

###### WHAT
Before the organisation **selects, accepts, modifies, or updates** any new or changed system component or service, it must carry out a security assessment that fits the item type and how it will be used. The organisation must **record and keep evidence** of the assessment to support go/no-go decisions and any follow-up actions.

###### WHY (control requirement)
SR-5(2) (Enhancement) requires these assessments **before selection, acceptance, modification, or updates** to find signs of **tampering**, **unintentional and intentional security weaknesses**, **malicious code or processes**, **backdoors or hidden access**, **faulty software**, and **counterfeits**. It also ensures the evidence is available for follow-on actions.

###### HOW (specific approach for this enterprise application context)
Set up an automated, auditable **Security Assessment Gate** that fits into your existing procurement, release, and change processes for the enterprise-managed application (web, application programming interface (API), client-server, microservices, software as a service (SaaS), and hybrid).

1. **Create an assessment catalogue** by item category (for example: application/library/service, container image, SaaS integration, managed service, firmware/agent). For each category, list the assessment methods required (for example: checking signatures and origin, reviewing a software bill of materials (SBOM), security testing such as static and dynamic testing, scanning dependencies for known weaknesses, controlled dynamic testing, fuzz testing where applicable, and penetration testing where risk justifies it).
2. **Use hard workflow gates** in the release, change, and procurement tools so that selection award, acceptance sign-off, change implementation approval, and update deployment cannot be completed unless an **assessment evidence package** is attached and confirmed as complete.
3. **Require clear evidence fields** in the evidence package, including: item identifier/version, assessment date and time, scope, methods used, results (including any tampering indicators and vulnerability findings), residual risk statement, and the decision outcome (proceed / proceed with conditions / stop and remediate).
4. **Automate evidence capture where possible** for this technology stack:
   - For software items: require **signature and checksum checks** and **SBOM ingestion**; run security testing such as static application security testing (SAST) and dependency scanning; record the outputs.
   - For containerised components: verify container image origin and signatures and run image scanning; record the outputs.
   - For API and web changes: run dynamic testing in a controlled environment and carry out targeted authorisation and authentication (authz/authn) regression testing and fuzz testing for exposed endpoints where applicable.
5. **Support independent or external assessment**: where required by risk level or procurement approach, require upload of independent assessment reports (including scope, method, date, and limitations) and link them to the same decision record.
6. **Check for counterfeit or tampering**: require origin controls (signatures, trusted registries, and approved sources). For any physical or logistics-supplied items (if any agents or firmware are involved), require completion of the organisation’s inspection step before the gate can be cleared.

###### WHO (roles responsible)
- **Application Owner / Change Owner**: confirms the correct item category and starts the gate.
- **Security Engineering / Application Security (AppSec)**: carries out, or commissions, the required assessment methods and produces the evidence package.
- **Procurement / Vendor Management**: ensures supplier materials and documentation are provided for assessment.
- **Independent assessor (internal or external)**: performs independent assessments when required by risk level or procurement approach.
- **Change Advisory Board (CAB) / Release Manager**: enforces the workflow gate and blocks deployment or acceptance without evidence.

###### Acceptance criteria
- No selection, acceptance, modification, or update workflow can be completed without an attached, validated assessment evidence package.
- Evidence packages include the required fields (scope, methods, results, decision outcome, residual risk) and are kept for audit purposes.
- For software items, signature/origin checks and SBOM-based checks are recorded; for web/API changes, dynamic testing and targeted fuzz testing and authz/authn regression testing are recorded where applicable.
- Independent assessment reports (when required) are linked to the same decision record.
- Audit checks confirm that evidence timestamps occur **before** the corresponding selection/acceptance/modification/update decision or deployment approval.

###### Actions Required for Compliance

- [ ] Create an assessment catalogue that links each item category to the required assessment method and the supporting evidence documents.
- [ ] Set up procurement, release, and change workflows with mandatory “hard stops” that prevent selection, acceptance, implementation, and updates until supporting evidence is provided.
- [ ] Set up automated evidence collection to prove where software artefacts came from (using digital signatures and checksums), bring in software bill of materials (SBOM) information, run static application security testing (SAST) and dependency scanning, and scan container images for known security issues.
- [ ] For any relevant changes to websites or application programming interfaces (APIs), run controlled automated tests that vary inputs in a controlled way and run focused regression tests for security and access-control behaviour, then record the results in the evidence package.
- [ ] Create a standard evidence pack template with the required fields: scope, methods, results, residual risk, decision outcome, and timestamps.
- [ ] For items and services where the risk level or procurement model requires external validation, require independent assessment report uploads and link each report to the decision record.
- [ ] Run a pilot release to test the gate, and carry out an audit sampling exercise to confirm that the required evidence is produced and approved before deployment or acceptance.


---

### SR-6 — Supplier Assessments and Reviews (Control)

This requirement is about making sure every supplier or contractor you rely on is properly checked for supply-chain and information risks—not just once, but regularly and whenever there are changes. Without these checks, a supplier could introduce weaknesses, mishandle sensitive information, fail to manage risks in its own subcontractors, or even supply counterfeit or compromised parts. This could then affect your services and harm your customers.

To meet this expectation, the organisation must assess and review the risks linked to each in-scope supplier and the system, component, or service they provide at least every year, and also whenever there is a significant supplier change or a security incident. These reviews must follow documented methods and plans. They must include checks for foreign ownership, control, or influence, and confirm that the supplier can also assess its own lower-tier suppliers and contractors.

The organisation must use documented procedures and evidence, relevant intelligence where available, and publicly available information. The reviews must be carried out either internally or by an independent third party. The organisation must keep clear records of the reviews and link the results to the relevant system and procurement documentation.

##### Automated supplier risk review workflow with FOCI and tiered assurance

- Category: Software
- Priority: Critical

###### WHAT
Set up a risk-based process to assess and review all suppliers and contractors that are in scope and that provide the system, a system component, or a system service. The process must run **at least once every year**, and also whenever there is any major supplier change or a security incident. It must collect evidence covering: the supplier’s security and supply-chain risk management processes and controls, **foreign ownership, control, or influence (FOCI)**, and the supplier’s ability to assess and manage **second- and third-tier** suppliers and contractors.

###### WHY (control requirement)
SR-6 requires the organisation to **assess and review supply-chain risks** linked to suppliers and contractors, and to the system, component, or service they provide. This must be done using a defined **frequency** (sr-06_odp), and must consider security and supply-chain risk management processes, **FOCI**, and the supplier’s ability to provide assurance for lower tiers. Reviews must use documented processes and controls, and consider documented evidence, information from multiple sources, and publicly available information.

###### HOW (specific steps/approach)
1. **Create an in-scope supplier register** that lists each supplier or contractor, the specific system or service they provide, the impact on data and access, and the applicable risk tier.
2. **Define risk tiers and triggers** for “major supplier change” and “security incident” (for example: change of ownership or control, change of subcontractor, major vulnerability disclosure affecting the supplier’s code or firmware, breach notification, changes to provenance or software development lifecycle evidence). Configure the process to run **at least annually** and on each trigger.
3. **Use a documented, evidence-based review template** (a workflow form) that requires the reviewer to record outcomes and attach evidence for:
   - The supplier’s security and supply-chain risk management processes and controls
   - **FOCI** screening results (documented)
   - The supplier’s ability to assess and manage **second- and third-tier** suppliers and contractors (evidence such as “flow-down” requirements, audit reports, or assurance statements)
   - Review of warning signs using documented sources, including checks for stolen information, weak development or quality control practices, information spillages, and counterfeit items (with references to the sources used)
   - Whether the review was carried out by the organisation or by an independent third party (and attach the report if a third party was used)
4. **Automate enforcement and make it auditable**: use workflow or orchestration so procurement and security cannot complete supplier onboarding or renewal unless the required SR-6 review fields for the supplier’s risk tier have been completed. Store all supporting material in an auditable repository, and **link each review record to the relevant system security documentation and procurement or contract file**.
5. **Make intelligence and public information checks part of the process**: include a controlled “sources consulted” step (for example, threat intelligence reports, vulnerability advisories, sanctions and ownership databases, and relevant public reporting) so the reviewer can provide evidence of the information from multiple sources and public information used in the review.
6. **Define sharing rules**: implement a documented decision step that shares assessment or review results with other organisations only when sharing is allowed by contract or law (and record the reason for sharing).

###### WHO (role responsible)
- **Supplier Risk Manager / Third-Party Risk Lead**: owns the supplier register, risk tiers, triggers, and review templates.
- **Procurement Owner**: ensures supplier onboarding or renewal cannot proceed without completion of the SR-6 workflow.
- **Information Security / Supply-Chain Security Assessor**: completes reviews, attaches evidence, and records the sources used.
- **Independent Third-Party Assessor (where required by tier)**: provides review reports and evidence.
- **Compliance/Audit Liaison**: checks the audit trail and that evidence is kept.

###### Acceptance criteria
- For every in-scope supplier or contractor, the system creates an SR-6 review record **at least once every year** and also for each configured major change or security incident trigger.
- Each review record includes auditable evidence for **FOCI** and documented confirmation of the supplier’s ability to assess and manage **second- and third-tier** suppliers and contractors.
- Each review record documents the evidence basis, including references to the intelligence and public sources used, and explicit consideration of stolen information, weak development or quality, information spillages, and counterfeit items.
- Each review record is linked to the relevant system or component or service documentation and the procurement or contract file.
- The workflow prevents onboarding or renewal from being closed unless the required SR-6 evidence fields for the supplier’s risk tier have been completed.

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date list of in-scope suppliers, showing which specific system or service each supplier provides.
- [ ] Define supplier risk levels and set up workflow alerts for an annual review, any major supplier change, and a security incident.
- [ ] Create an SR-6 review template that requires proof of security and supply-chain risk management processes, foreign ownership, control, or influence (FOCI) controls, and the ability of lower-tier suppliers to provide assurance.
- [ ] Add a controlled record of every “source consulted” so that all information used in each review—both intelligence sources and publicly available information—is documented as evidence.
- [ ] Prevent procurement onboarding or renewal from completing unless the supplier’s risk tier has had the SR-6 review completed.
- [ ] Store the results of each review in an auditable record system, and link every record to the related system security documentation and the relevant procurement or contract file.


---

#### SR-6.1 — Testing and Analysis (Enhancement)

This expectation is about checking, before and while software and firmware are being built and updated, that the people and tools involved—and any external partners who help integrate the software—are working in a trustworthy way. If this is not done, a hidden flaw, an unauthorised change, or a risky practice could enter the development process, the change-tracking tools, or the work of a third-party integrator, and later lead to service disruption, data loss, or financial harm.

To meet this requirement, the organisation must do its own analysis and testing and also arrange independent testing by an external party. This applies to the software and firmware development processes, the configuration management tools used to track and control changes, and the third-party integrators. The organisation must set out what will be tested and how, assign clear responsibility, keep an up-to-date list of the supply-chain components covered, and maintain the relevant plans and procedures. Finally, it must record the testing results and use them to guide supply-chain risk decisions.

##### Dual internal + independent testing for supply-chain elements

- Category: Manual
- Priority: Critical

###### WHAT
Set up a repeatable “supply-chain assurance package” so that, for every system release or major change, you analyse and test the defined parts of the supply chain—specifically **software and firmware development processes, configuration management tools, and third-party integrators**—using both **internal testing** and **independent third-party testing**. Then **record the evidence** that is used to make supply-chain risk decisions.

###### WHY (control requirement)
SR-6(1) Enhancement requires using **{{ sr-06.01_odp.01 }}** from the following supply chain elements, processes, and actors: **{{ sr-06.01_odp.02 }}**. The guidance also requires that evidence created during analysis and testing is **documented** and **used to inform the organisation’s risk management activities and decisions**.

###### HOW (specific approach)
1. **Define what is in scope** for each system or service in a maintained register (for example: software/firmware development teams, configuration management tool owners, and third-party integrators). Make sure the register clearly matches the scope in **sr-06.01_odp.02**.
2. **Create a standard dual-testing test plan** for each in-scope category:
   - **Software/firmware development processes**: check that you have secure development evidence (for example: coverage of threat modelling, secure coding standards, how secrets are handled, continuous integration and continuous delivery controls, and build/release controls).
   - **Configuration management tools**: check that you have evidence of controlled changes and origin (for example: branch protection and code review enforcement, audit logs, access controls, and attestation/provenance where available).
   - **Third-party integrators**: check that you have controls for integration and release packaging (for example: how dependencies are taken in, build orchestration, and how release items are handled).
3. **Carry out internal testing and analysis** for each release or major change:
   - Gather and review supplier evidence packs (pipeline logs/exports, samples from configuration management audit logs, provenance/attestation outputs, and software bill of materials (SBOM) or artefact consistency where used).
   - Do focused internal technical checks on the supplier’s claims that relate to how they integrate (for example: confirm that build provenance/attestation exists and matches the release artefacts).
4. **Commission independent third-party testing and analysis** for the same in-scope categories:
   - Ask the independent tester to check the supplier’s development, configuration, and integration controls, and—where your integration model requires it—to carry out penetration testing or other security validation of the integration pathways and build/deployment mechanisms.
   - Make sure the independent report includes findings that support decisions, including severity/impact and references to the evidence used.
5. **Record results and use them for risk decisions**:
   - Store both internal and independent evidence in an auditable “assurance package” linked to the relevant release/change record.
   - Share findings with the organisation’s supply-chain risk management function so risk decisions can be updated (for example: accept, mitigate, or reject; add compensating controls; increase monitoring; or trigger re-testing).
6. **Make governance operational**:
   - Build the dual-testing requirement into your supply-chain risk management (SCRM) strategy and implementation plan, and into your system security plan, so it is carried out consistently for every release or major change.
   - Assign named responsibilities for: (a) internal testing and analysis, (b) commissioning independent testing, and (c) approving risk decisions.

###### WHO
- **Supply Chain Risk Manager / SCRM lead**: owns the assurance package process, ensures risk decisions use the evidence, and runs approval gates.
- **Information Security / AppSec lead**: sets the technical testing criteria and confirms the evidence is sufficient.
- **Engineering/DevOps lead**: provides the artefacts and pipeline/provenance evidence, and coordinates internal testing.
- **Procurement / Vendor management**: ensures independent testing is enabled through contracts for third-party integrators.
- **Independent third-party testing provider**: performs the independent testing and analysis and produces auditable evidence.

###### Acceptance criteria
- For each release or major change, an assurance package exists and includes **both** internal testing evidence and **independent third-party testing evidence** covering the in-scope categories in **sr-06.01_odp.02**.
- The assurance package can be traced to the specific release/change record and contains enough evidence to support supply-chain risk decisions.
- Supply-chain risk decisions are updated based on documented findings (for example: documented risk acceptance with reasons, or documented mitigations and re-testing triggers).
- Named roles are responsible for carrying out internal testing, commissioning independent testing, and approving risk decisions.

###### Actions Required for Compliance

- [ ] Create and keep up to date an in-scope supply chain register that links each system or service to the categories listed in **sr-06.01_odp.02**.
- [ ] Create a test plan that uses two types of testing across the software and firmware development process, the configuration management tools, and third-party integration partners.
- [ ] Set up an assurance process that requires proof of internal testing and analysis for every release or major change.
- [ ] Require, through the contract, independent third-party testing and analysis for the same in-scope categories, and require auditable evidence outputs.
- [ ] Set up an approval step (gate) so that supply-chain risk decisions are updated using documented internal findings and independent findings.
- [ ] Store all evidence in a repository that can be audited and is linked to each software release, and keep it for compliance reviews.


---

### SR-7 — Supply Chain Operations Security (Control)

This requirement is about preventing sensitive information—such as what you buy, how you use it, and who it is for—from being leaked through your suppliers. Without these controls, a determined outsider could use clues from normal purchasing and delivery activity, supplier paperwork, and shared technical information to work out who uses your services, what they do with them, and how your systems are built. This could give them a head start to cause disruption or harm.

To meet this expectation, the organisation must first identify the most critical supply-chain information (including details about users and use, supplier identities and processes, and design and testing results). It must then assess what suppliers and others could realistically see and deduce. The organisation must agree appropriate safeguards with suppliers through procurement documents and contracts, check that the risk is reduced to an acceptable level, and consider how combining several small pieces of information could increase overall exposure.

Where necessary, the organisation must limit or withhold sensitive details and use intermediaries so suppliers cannot easily learn the final use or the final users.

##### Supply-chain OPSEC inference analysis and critical info classification

- Category: Manual
- Priority: Critical

###### WHAT
Set up a repeatable supply-chain operational security (OPSEC) process that (1) defines what supply-chain-related information is covered for each system/component/service, (2) identifies and categorises the organisation’s most important supply-chain information (including supplier identities/processes, system/component settings, design details, and testing/evaluation results), (3) assesses what an attacker could learn from our actions and visible signs (including what could be learned by combining information from multiple sources and time periods), and (4) creates clear, enforceable rules for what we may share with suppliers.

###### WHY (control requirement)
SR-7 requires the organisation to use OPSEC to protect supply-chain-related information by identifying critical information, analysing our actions/visible signs and what an attacker could infer (including combined exposure), putting safeguards/countermeasures in place to reduce risk to an acceptable level, and limiting or withholding sensitive details from suppliers and/or using intermediaries where required.

###### HOW (specific steps/approach)
1. **Define the supply-chain OPSEC scope for each procurement item**: For each system/component/service (including software as a service (SaaS), managed services, and third-party integrations), record which types of supply-chain information are covered: user identities/uses, supplier identities, security/privacy requirements, settings, supplier processes, design specifications, and testing/evaluation results.
2. **Create a “critical supply-chain information” register**: Keep a structured register that links each information type to its sensitivity level and the exact protection requirements (for example, “may be shared under a non-disclosure agreement (NDA) with redaction”, “must not be shared directly”, “share only through a secure intermediary”).
3. **Run adversary learning workshops**: Carry out structured OPSEC analysis of what an attacker could work out, using information from across the organisation (for example, procurement emails, delivery dates, onboarding steps, how detailed technical documents are, and naming conventions for environments). For each visible sign, record what an attacker might reasonably conclude and what harm could result.
4. **Assess combined (aggregated) exposure**: Identify combinations of items that may seem harmless on their own, but could reveal end users/uses or system configuration details when combined (across documents, tickets, time periods, regions, or customer environments) in time to cause harm.
5. **Turn the results into rules for sharing with suppliers**: Create a controlled set of “share/redact/withhold” rules and required handling instructions for procurement and supplier management teams (including guidance on what to redact at field level and how to transfer information securely). Make sure the rules clearly cover withholding/restricting end-use/end-user details where sharing increases risk.
6. **Produce audit-ready evidence**: Store the scope definition, the results of the learning and combined exposure analysis, and the resulting sharing rules in a central repository linked to each procurement item.

###### WHO
- **OPSEC lead / Information Security Manager**: owns the OPSEC approach, runs the workshops, and approves the sharing rules.
- **Procurement category manager + Supplier management**: ensures the correct scope is applied to procurements and that supplier-facing documents follow the rules.
- **System owner / Product owner**: provides accurate information about intended uses, settings, and testing/evaluation evidence.
- **Threat intelligence / Security engineering**: supports the adversary learning and combined exposure analysis.

###### Acceptance criteria
- For each in-scope system/component/service procurement, there is a completed supply-chain OPSEC scope document and a populated critical supply-chain information register.
- Adversary learning analysis exists for each procurement item, including recorded observable indicators and plausible conclusions.
- Combined exposure analysis is completed, with clear identification of combinations that could reveal end users/uses or sensitive settings.
- Supplier-facing sharing rules are produced and approved, with clear “share/redact/withhold” decisions and handling instructions.
- Evidence is stored centrally and can be retrieved for audit (scope, learning/combined exposure outputs, and approved sharing rules).

###### Actions Required for Compliance

- [ ] Create a supply-chain operational security (OPSEC) scope template that covers: who will use it and how it will be used, the identities and processes of suppliers, the configurations and design specifications, and the results of any testing and evaluation.
- [ ] Maintain a critical supply-chain information register that records each item’s sensitivity level and sets clear protection and handling requirements for each type of information.
- [ ] Run adversary inference workshops to record observable signs from friendly actions and the most likely ways an adversary could interpret them.
- [ ] Carry out an analysis of how data is combined to find combinations that could reveal who is using the system, how it is being used, or sensitive configuration details.
- [ ] Publish the approved rules for what suppliers may see (share), what should be hidden (redact), and what should not be provided (withhold), along with secure handling instructions for each procurement item.
- [ ] Store audit-ready evidence that links the operational security (OPSEC) scope, the inference and aggregation results, and the resulting sharing rules to each system, component, and service purchased.


---

### SR-8 — Notification Agreements (Control)

This requirement is about making sure your suppliers and other partners tell you quickly if they find a problem in their products or services that could harm your systems, or if they think one might exist. If there are no clear, agreed notification rules, a serious supply-chain problem could go unnoticed for too long, leaving you unable to respond, protect customers, or reduce the damage.

To meet this expectation, the organisation must:
- identify all supply-chain partners involved in providing the system, key components, or services; and
- put written agreements in place that set out:
  - what must be reported,
  - what information must be included,
  - when they must notify you, and
  - how to contact you (including named points of contact and approved communication channels).

These agreements must also require partners to share relevant assessment or audit results, including useful information from public sources, so they can fix the issue and improve their processes.

The organisation must record these requirements in procurement and contract documents, ensure service agreements include the same notification expectations, assign named responsibilities internally, and document the approach in the system security plan or related records.

##### Enforceable supplier compromise notification clauses and onboarding

- Category: Manual
- Priority: Critical

###### WHAT
Put in place written, enforceable agreements and procedures with every supply-chain organisation involved in providing the system, system component, or system service ({{ insert: param, sr-08_odp.01 }}). These agreements must require them to notify us quickly about both **confirmed** and **potential** supply-chain problems that could harm (or have already harmed) our organisational systems/components. The agreements must also require them to share **relevant assessment/audit results** ({{ insert: param, sr-08_odp.02 }}) and **relevant information from public sources** that helped them carry out the assessment or make the decision.

###### WHY (control requirement)
SR-8 requires the organisation to “establish agreements and procedures with entities involved in the supply chain” for the stated purpose (sr-08_odp.01). The guidance highlights that early notification of supply-chain problems is important for effective incident response. It also notes that assessment/audit outcomes and useful public-source information can help the supply-chain organisation address concerns or improve its processes.

###### HOW (specific steps/approach)
1. **Identify and categorise supply-chain partners** for the application’s important components/services (for example: software as a service providers, managed service providers, key application programming interface/data providers, hosting/infrastructure providers, and critical third-party libraries).
2. **Create a standard contract schedule / service level agreement (SLA) addendum** titled “Supply-chain Compromise Notification”, including:
   - Coverage for **confirmed** and **potential** supply-chain problems affecting the organisation’s systems/components.
   - Required notification details (what happened, which components/services are affected, any known impact, and initial containment actions).
   - Notification time expectations matched to severity levels (set clear time-to-notify targets).
   - Approved ways to notify us (for example: a secure incident contact email alias and/or a ticketing portal) and **named points of contact**.
   - Mandatory sharing of **relevant assessment/audit results** (sr-08_odp.02) that relate to the problem.
   - Mandatory sharing of **relevant information from public sources** that informed the supplier’s assessment or decision.
3. **Use a procurement approval step** so that no important supplier contract/SLA is signed unless the SR-8 notification schedule is attached and accepted.
4. **Complete supplier onboarding confirmation** (security plus procurement) to record the supplier’s current notification contacts, channels, and escalation route. Also ensure the signed clause is linked to the application/system security plan section covering supply-chain communications.
5. **Keep an auditable supplier register** that links: supplier organisation → contract/SLA identifier → system/component/service scope → notification clause version → named contacts → location where the signed agreements are stored.

###### WHO (role responsible)
- **Procurement Lead**: ensures the contract/SLA includes the requirement and enforces it through the procurement approval step.
- **Information Security / Cybersecurity Lead**: sets the notification scope, severity levels, required notification content, and onboarding confirmation requirements.
- **Application Owner / Service Owner**: provides the list of important components/services and ensures the system security plan refers to the SR-8 procedure.
- **Legal/Commercial Counsel**: reviews and finalises the wording of the clause so it is enforceable.

###### Acceptance criteria (audit-ready)
- A **complete supplier register** exists for all important supply-chain organisations relevant to the application’s systems/components/services.
- For each listed organisation, there is a **signed contract/SLA** that includes the SR-8 “Supply-chain Compromise Notification” schedule.
- Each agreement clearly requires notification of **confirmed and potential** supply-chain problems. It must state **what/when/how** to notify us (including named contacts and approved notification channels) and require sharing of **sr-08_odp.02** (relevant assessment/audit results) and **relevant information from public sources** where applicable.
- The application/system security plan (or a linked record) refers to the SR-8 notification procedure and the official location of the supplier register.
- Evidence is kept in a controlled repository (contract identifiers, clause version, and supplier onboarding contact confirmation records).

###### Actions Required for Compliance

- [ ] Create a list of material suppliers for the application’s system components and services, including contract reference numbers and named contacts for security notifications.
- [ ] Draft a standard contract schedule for “supply-chain compromise notification” that covers confirmed and possible compromises, the required information, when notifications must be sent, and the approved ways to send notifications.
- [ ] Add mandatory clauses requiring the supplier to share relevant assessment and audit results (sr-08_odp.02), and any relevant information from public sources where that information influenced the supplier’s assessment or decision.
- [ ] Require a procurement approval step so that no contract or service-level agreement (SLA) with a material supplier is signed unless the SR-8 notification schedule is attached and has been accepted.
- [ ] Onboard suppliers by confirming the named points of contact, the escalation route, and the notification channels, and then record the evidence in the approved document repository.
- [ ] Update the application or system security plan (or the linked record) to reference the SR-8 notification procedure and the approved supplier register.


---

### SR-9 — Tamper Resistance and Detection (Control)

This requirement is about making sure key systems, components, or services are difficult to secretly change, and that any such interference is detected quickly. Without this, someone could replace a genuine part with a modified or counterfeit one, or alter the software or service behaviour during delivery or while it is in use. This could lead to fraud, disruption, or the exposure of sensitive information.

To meet this expectation, the organisation must set up and maintain a tamper protection programme for the items in scope. The programme must clearly state what is covered, who is responsible, and the written steps for both preventing unauthorised changes and detecting them during delivery and during normal operation. It must also document the tools and methods used, keep the programme and related records up to date, and ensure the same tamper protection expectations are built into purchasing decisions, supplier contracts, and service agreements—supported by evidence that suppliers are assessed against these requirements.

##### Tamper protection programme using signed artefacts and delivery checks

- Category: Software
- Priority: Critical

###### WHAT
Set up and run a documented tamper protection programme for the in-scope application and the services that support it. The programme must: (1) make unauthorised changes or swaps difficult by using tamper-resistant controls (for example, signed files and controlled deployment), and (2) detect tampering both when software is delivered/received and during normal use (for example, checking integrity and monitoring for unexpected changes).

###### WHY (control requirement)
SR-9 requires a tamper protection programme for the system, system component, or system service. The guidance stresses that anti-tamper technologies, tools, and methods should protect against reverse engineering, unauthorised modification, and substitution. It also states that strong identification, combined with tamper resistance and/or tamper detection, is essential both during distribution and while the system is in use.

###### HOW (specific steps/approach)
1. **Define scope and tamper points**: document which items are in scope (for example, application files, configuration bundles, container images, firmware bundles where relevant, infrastructure as code (IaC) modules, deployment instructions, and third-party dependency packages). Also define what counts as “tampering” (for example, unsigned files, changed build outputs, unexpected version or configuration changes, or substitution during receiving).
2. **Create the tamper protection programme document**: include procedures for both tamper resistance and tamper detection during **delivery** (receiving/acceptance) and **in use** (runtime/integrity monitoring). Include escalation and response steps when checks fail.
3. **Implement tamper resistance using signed files**: use a secure build and release process that produces cryptographically signed files (for example, signed container images and signed packages/manifests). Ensure deployment and orchestration tools only accept files with valid signatures and expected origin information.
4. **Implement delivery/receiving checks**: require suppliers and internal release processes to provide verifiable signature information and checksums/manifests. Receiving staff (or automated receiving gates) must validate signatures/checksums before anything is accepted into any environment.
5. **Implement detection during use**: run regular integrity checks and configuration drift detection against an approved baseline (expected versions/hashes/configuration). Send any verification failures and drift events to the security information and event management (SIEM) system for alerting and incident handling.
6. **Build requirements into purchasing and service agreements**: update procurement templates and service level agreements (SLAs) so suppliers must provide signed release files and origin information, and must support signature/checksum checks at delivery. Keep evidence that these tamper-related requirements were included in contracts.
7. **Maintain audit-ready evidence**: keep records of signature validation results, deployment acceptance decisions, integrity check results, and exception handling. Ensure the programme is reviewed and updated when releases or processes change.

###### WHO (role responsible)
- **Application Owner / Service Owner**: responsible for defining the programme scope, the baseline, and ensuring operational integrity checks are carried out.
- **Security Engineering / DevSecOps Lead**: implements signing, verification gates, and detection logic.
- **Release Manager / CI/CD Engineer**: ensures signed file creation and captures origin information.
- **Procurement / Vendor Management**: updates purchasing terms and checks supplier compliance.
- **Security Operations Centre (SOC) / SIEM Operations / Incident Response Lead**: investigates and responds to tamper detection alerts.

###### Acceptance criteria
- A documented tamper protection programme exists and clearly covers the in-scope system/component/service, including procedures for both delivery and in-use detection.
- Production (and other approved) deployments are blocked unless files are cryptographically signed and verification is successful.
- Delivery/receiving includes signature/checksum/origin validation, with evidence recorded.
- In-use integrity and drift checks run on a defined schedule (or are triggered by events) and produce alerts when verification fails.
- Acquisition and SLAs include tamper-related requirements for files and origin information, and evidence is kept showing these requirements were specified and verified.
- Verification logs and exception records are kept in an auditable form for the required retention period.

###### Actions Required for Compliance

- [ ] Define and document the scope of SR-9, including which systems, components, and services are included, and list the tamper points and items (artefacts) that must be protected.
- [ ] Create the tamper protection programme section, including: delivery and receiving verification, integrity checks while the system is in use, and tamper response procedures.
- [ ] Add cryptographic signing for release files (for example, container images, software packages, and deployment manifests) within the continuous integration and continuous delivery (CI/CD) pipeline.
- [ ] Set up deployment admission controls to block any software packages that are not signed or cannot be verified, and record whether each package was admitted and whether its verification succeeded or failed.
- [ ] Set up receiving gates that verify supplier or internal signatures and file checksums before any files are accepted into any environment.
- [ ] Set up checks for runtime (in-use) integrity and configuration drift against an approved baseline, and send any failures to the security information and event management (SIEM) system for alerting.
- [ ] Update procurement templates and service-level agreements (SLAs) to require signed and verifiable deliverables, and keep records showing the supplier’s compliance and how their verification was carried out.


---

#### SR-9.1 — Multiple Stages of System Development Life Cycle (Enhancement)

This requirement is about ensuring systems are designed, built, and managed in a way that makes unauthorised interference difficult and that can detect it quickly. This must be done from the earliest planning through to disposal. Without this, someone could tamper with parts or software during development, delivery, or everyday use, or swap in altered components through suppliers. This could cause hidden faults, fraud, or service disruption that may be difficult to spot.

To meet the expectation, the organisation must set out its approach to preventing and detecting tampering in its development and acquisition records, and apply it at every stage of the system’s life cycle. This includes research and design, manufacturing, purchasing, delivery, integration, operations and maintenance, and disposal. It must record the specific procedures for resisting tampering and detecting it, the tools and methods used, and how protection across the supply chain is handled. These expectations must also be included in procurement policies, contracts, and service agreements.

Finally, the organisation must clearly assign responsibilities to the appropriate roles and keep evidence showing the measures were actually applied and can be followed in practice.

##### SDLC stage-gates for anti-tamper resistance and detection evidence

- Category: Software
- Priority: Critical

###### WHAT
Set up an anti-tamper engineering and evidence approach that is used at every stage of the software and system development life cycle (research and development, design, manufacturing/build, acquisition, delivery, integration, operations and maintenance, and disposal). The approach must cover both **tamper resistance** (making tampering harder) and **tamper detection** (spotting tampering). It must also produce **evidence that is ready for audit**, showing that the required measures were actually carried out.

###### WHY (control requirement)
SR-9(1) (Enhancement) requires: **“Employ anti-tamper technologies, tools, and techniques throughout the system development life cycle.”** The guidance clearly covers the full life cycle (from research and development through to disposal). It also specifically calls for **obfuscation** and **self-checking** to make reverse engineering and unauthorised changes harder, and for measures that limit damage by detecting substitutions.

###### HOW (specific steps/approach)
1. **Create an anti-tamper control catalogue** with two clear categories:  
   - **Resistance** (for example: signed documents/artifacts, secure build provenance, hardware/software “roots of trust” where applicable, tamper-evident packaging for delivered parts, code obfuscation where feasible)  
   - **Detection** (for example: integrity checks, self-check routines, runtime attestation, integrity measurement, and tamper-evident logging)
2. **Link the catalogue to stage-gates in your life cycle templates** (including separate gates for development/test/production and for delivery/integration). Each gate must include at least one **resistance** expectation and one **detection** expectation where applicable.
3. **Add verifiable acceptance checks to engineering outputs at each stage**:
   - **Design/R&D:** include tamper scenarios in threat modelling; specify integrity/self-check points and the expected response.
   - **Build/Manufacture (for software: build pipeline):** signed outputs and provenance attestation; generate a software bill of materials (SBOM); use a reproducible build approach where feasible.
   - **Acquisition/Delivery/Integration:** perform integrity checks when receiving items; include “no unsigned/unauthorised artifacts” checks; include expectations for substitution detection.
   - **Operations/Maintenance:** set self-check/integrity monitoring triggers; define an escalation/incident process when tamper indicators are found.
   - **Disposal:** provide evidence of secure wiping or destruction for any stored keys/artifacts and decommissioned components.
4. **Automate evidence collection** so each stage-gate produces machine-checkable outputs linked to the system record (for example: CI/CD signing/provenance logs, SBOMs, integrity check results, and the history of operational self-check alerts). Store evidence in an auditable repository with controls that prevent changes (immutable retention).
5. **Use “detection as code”** for operational self-checking/integrity verification, so the same logic is version-controlled, reviewed by peers, and traceable back to the stage-gate requirements.
6. **Maintain one single “anti-tamper programme” document** that points to the stage-gate templates, lists the approved anti-tamper tools/techniques, and sets out responsibilities and where evidence is stored.

###### WHO (role responsible)
- **Application Security Lead / Security Engineering:** owns the anti-tamper control catalogue, stage-gate requirements, and detection-as-code standards.
- **SDLC/Release Manager:** updates life cycle templates and ensures stage-gate requirements are enforced during delivery.
- **Platform/DevOps Engineering:** implements signing/provenance, SBOM generation, and evidence automation in CI/CD.
- **Operations Lead / Security Operations Centre (SOC) (where applicable):** ensures runtime self-check triggers, alerting, and escalation procedures are put into day-to-day operation.

###### Acceptance criteria
- For each stage-gate, there is a documented set of anti-tamper requirements that includes **both** resistance and detection expectations (where applicable).
- Build/delivery outputs are **signed** and include provenance and/or SBOM evidence stored in an auditable repository.
- Integration/delivery includes **integrity verification** on receipt, with recorded results.
- Operational self-checking/integrity monitoring exists and produces tamper-indicator logs/alerts linked to the system record.
- Disposal/decommissioning produces evidence of secure wiping or destruction for relevant artifacts/keys/components.
- A complete evidence trail can be produced for an audit showing that SR-9(1) measures were applied across the life cycle for a representative release.

###### Actions Required for Compliance

- [ ] Create an anti-tampering control catalogue that lists resistance and detection methods suitable for the application stack.
- [ ] Update the software development lifecycle (SDLC) stage-gate templates so that each SDLC stage includes anti-tampering resistance requirements and acceptance criteria for detecting tampering.
- [ ] Set up continuous integration and continuous delivery (CI/CD) to produce signed release files, proof of where they came from (provenance attestations), and software bills of materials (SBOMs). Store the supporting evidence in a way that cannot be changed for each release.
- [ ] Set up checks to verify the integrity of delivered and integrated items, so that unsigned or unauthorised items are blocked, and record the results of each verification.
- [ ] Set up ongoing checks to confirm the software is still intact while it runs, with alerts if tampering is suspected, and with documented steps for how to escalate and respond.
- [ ] Define and provide proof of secure disposal and decommissioning steps for keys, digital items (artefacts), and components, linked to the system record.


---

### SR-10 — Inspection of Systems or Components (Control)

This requirement is about making sure the physical parts and built-in components of your on-site equipment have not been secretly changed before they are trusted and used. Without regular checks, someone could tamper with the equipment or its built-in software so that it behaves differently, which could allow attackers to intercept data, disrupt services, or get around safeguards.

To meet this expectation, the organisation must:
- define which on-site hardware and built-in components are covered by these checks;
- select items at random and inspect them at least once every quarter for signs of tampering.

Inspections must look for both:
- **physical tampering**, such as signs the equipment has been opened or altered seals/labels; and
- **logical tampering**, such as unexpected built-in software or changes to settings.

Any components that have been removed from controlled areas must be inspected before they are put back into use.

More frequent inspections are required when any of the following change:
- packaging,
- specifications,
- factory location, or
- supplier identity,

or when staff return from travel to high-risk locations.

Named staff must carry out the checks, keep records and reports of what was inspected, what was found, and any follow-up actions.

##### Quarterly random tamper inspections for in-scope on-prem hardware

- Category: Manual
- Priority: Critical

###### WHAT
Set up an inspection programme that is auditable and does the following:  
(1) **At least once every quarter**, it randomly selects from the organisation’s approved list of **systems or system components** (sr-10_odp.01), and  
(2) it inspects each selected component for **physical and logical signs of tampering**.  

Also, carry out inspections when components are **taken out of organisation-controlled areas** and before they are put back into use, and when there are **defined reasons to inspect** (sr-10_odp.04), including **after travel to high-risk locations**.

###### WHY (control requirement)
SR-10 requires inspection of the specified systems/components to detect tampering. This must use a **random** approach (sr-10_odp.02) and happen **at least quarterly** (sr-10_odp.03). Inspections must also be triggered when there are **defined signs that inspection is needed** (sr-10_odp.04). The guidance specifically includes both **physical and logical tampering** and applies to components **removed from organisation-controlled areas**.

###### HOW (specific approach)
1. **Define and keep the inspection scope list up to date**: Maintain an official inventory of in-scope on-prem components (for example, network devices, servers, storage, and security appliances). Each item must have a unique identifier (asset tag or serial number), references to the expected firmware/software starting point, and its current location and whether it is in an organisation-controlled area.
2. **Use a random selection method that can be proven**: Every quarter, create a documented random sample from the in-scope inventory (sr-10_odp.02). Record the selection details (the inventory snapshot time, the selection method/seed, and the selected asset identifiers). Make sure the selection can be reproduced for audit purposes.
3. **Carry out physical tampering checks** for each selected asset: Check tamper-evident seals/labels, look for signs that the enclosure has been opened, inspect for unexpected changes to cables or ports, and capture photo evidence where possible. Record the result (pass/fail) and any observations against the exact asset identifier.
4. **Carry out logical tampering checks** for each selected asset: Confirm firmware/software versions match the expected baselines; verify configuration integrity (for example, compare against known-good configuration checks or approved configuration exports where available); and confirm that management settings and security-relevant settings have not changed unexpectedly.
5. **Carry out inspections outside the normal schedule when required**: If any defined reason to inspect occurs (sr-10_odp.04)—such as changes in packaging, specifications, factory location, or supplier entity—or when staff return from travel to high-risk locations, and when components leave or return to organisation-controlled areas, send the affected asset into the same inspection process **before it is used again**.
6. **Record and keep audit evidence**: Store inspection records (selection evidence, checklist results, firmware/configuration values, photos, and any follow-up actions such as quarantine, escalation, or replacement) in the organisation’s governance, risk and compliance (GRC) or ticketing system, or in a workflow linked to the configuration management database (CMDB). Ensure there is clear ownership and timestamps.

###### WHO
- **Infrastructure/Operational Technology (OT)/Information Technology (IT) Asset Owner or Security Operations Lead**: owns the inspection programme, the baselines, and the trigger criteria.
- **Authorised technicians/engineers**: carry out the physical and logical inspections using the standard checklists.
- **GRC/Compliance or Security Assurance**: checks that quarterly random selection and evidence retention meet the auditability requirements of SR-10.

###### Acceptance criteria
- Quarterly reports show **randomly selected** assets from the official in-scope list (sr-10_odp.01), with documented selection evidence (sr-10_odp.02), completed on an **at least quarterly** basis (sr-10_odp.03).
- For every selected asset, there is inspection evidence for both **physical and logical** tampering checks.
- Any asset returned from outside organisation-controlled areas is inspected before it is used again.
- Inspections outside the normal schedule are triggered and evidenced for all occurrences of the defined reasons to inspect (sr-10_odp.04), including after travel to high-risk locations.
- Inspection results and follow-up actions are recorded against the exact asset identifiers and kept for audit.

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date, official list of all in-scope on-premises systems and components. Each item must have a unique identifier and be marked as either inside or outside a controlled area.
- [ ] Create standard checklists for physical and digital (logical) tamper inspections, based on the expected firmware, software, and configuration baseline for the system.
- [ ] Run a documented quarterly random selection process using the inventory snapshot, and keep evidence showing how each selection was made.
- [ ] Carry out physical and digital checks for signs of tampering on each randomly selected asset, and record the results against the asset’s ID.
- [ ] Carry out inspections outside the normal schedule before re-use if components leave or return from areas controlled by the organisation, or if there are indications of **sr-10_odp.04**.
- [ ] Store inspection records—selection evidence, findings, photos, firmware and configuration values, and follow-up actions—in an auditable system with defined retention periods.


---

### SR-11 — Component Authenticity (Control)

This requirement is about ensuring that any parts you buy and use in your systems are genuine, not fake lookalikes. If counterfeit parts enter your supply chain, they can fail early or be deliberately changed to cause harmful behaviour, putting your organisation’s operations and data at risk.

To meet this expectation, the organisation must create an anti-counterfeit policy, get it formally approved, and apply it across purchasing and receiving activities. This includes parts sourced from manufacturers, developers, vendors, and contractors.

The organisation must also create and follow clear procedures that tell staff how to check for suspicious parts before they are accepted, how to prevent them from entering or being used if there is a concern, and what immediate actions to take.

If counterfeit parts are identified, staff must promptly report them to the system security officer and the supply chain risk management lead, and, where appropriate, also report them to the Cybersecurity and Infrastructure Security Agency (CISA).

##### Anti-counterfeit procurement receiving gate with CISA reporting

- Category: Software
- Priority: Critical

###### WHAT
Put in place an organisation-approved anti-counterfeit policy and enforce clear receiving and procurement steps to stop counterfeit parts from entering the application’s environments. Create a “receiving gate” step that requires proof of traceability, and that sends any suspected or confirmed counterfeit findings to the system security officer and the supply chain risk management lead. Ensure there is a clear, auditable decision trail for any required external reporting to the Cybersecurity and Infrastructure Security Agency (CISA).

###### WHY (control requirement)
Security Requirement SR-11 (Component Authenticity) requires anti-counterfeiting policies and procedures that:
- make tampering harder, and
- protect against the introduction of malicious code,
covering sources such as manufacturers, developers, vendors, and contractors.

It also requires that counterfeit components are reported quickly to the defined internal recipients and, where appropriate, to external reporting organisations (default: CISA).

###### HOW (specific steps/approach)
1. **Policy & scope**: Create and formally approve an anti-counterfeit policy covering all relevant ways we acquire components (manufacturers, developers, vendors, contractors). The policy must clearly define:
   - what staff should do to detect and prevent counterfeit items during procurement and receiving,
   - what to do with items that need to be held or quarantined,
   - who to report to internally (system security officer; supply chain risk management lead), and
   - the decision steps for whether and how to report to CISA externally.
2. **Procedures**: Publish anti-counterfeit procedures for procurement and receiving staff, and for any engineering teams that accept components for installation. The procedures must include practical ways to spot suspicious components before acceptance/installation, and clear steps to stop or hold items if concerns arise.
3. **Receiving gate (workflow enforcement)**: Set up the procurement/receiving workflow (for example, an enterprise resource planning (ERP) or procurement system and/or a configuration management database (CMDB) or asset intake process) so that installation/acceptance cannot happen unless required evidence is provided and checked for the relevant component category (based on risk).
   - **Required evidence (examples to implement as your policy requires)**: manufacturer identity, part/serial/lot identifiers, a certificate of conformance (COC) of the required type, and a chain-of-custody reference.
   - **Evidence consistency checks**: confirm that the identifiers match across the purchase order, packing list, and certificate, and that the supplier is on the approved list for that component category.
4. **Quarantine & exception handling**: If evidence fails or suspicion is raised, automatically place the item into a **quarantine/hold** status and prevent installation. Use an exception approval workflow that routes the case to the system security officer and the supply chain risk management lead.
5. **Reporting & audit trail**: For any suspected or confirmed counterfeit finding, create a structured incident or supply-chain ticket that records:
   - component identifiers (part/serial/lot), supplier/source, and dates,
   - the evidence that triggered the concern,
   - the immediate containment actions taken,
   - the internal notifications made to the system security officer and the supply chain risk management lead.
   
   Also keep a documented decision record showing whether external reporting to **CISA** was made (or not), including the minimum details required by the procedures.

###### WHO (role responsible)
- **Supply chain risk management lead**: owns the anti-counterfeit policy and procedures, and owns the decision process for reporting.
- **System security officer**: is the internal reporting recipient and the authority to approve exceptions for counterfeit/suspicion outcomes.
- **Procurement/receiving operations**: run the receiving gate and provide the required evidence.
- **IT/asset management (CMDB) and workflow owners**: implement the hold/quarantine and the workflow controls that block installation.

###### Acceptance criteria
- The anti-counterfeit policy is formally approved, version-controlled, and covers sources (manufacturers/developers/vendors/contractors).
- Anti-counterfeit procedures exist and are available to receiving/procurement staff; they include detection/prevention steps and clear hold/stop actions.
- Receiving/installation is blocked in the workflow when required traceability evidence is missing or does not match.
- Suspected or confirmed counterfeit items trigger an auditable ticket routed to the system security officer and the supply chain risk management lead.
- The ticket includes an auditable decision record for external reporting to CISA (reported vs not reported, with justification).
- Evidence checks and quarantine/hold actions produce audit-ready records for review.

###### Actions Required for Compliance

- [ ] Draft and obtain formal approval for an anti-counterfeiting policy covering manufacturers, developers, vendors, and contractors.
- [ ] Publish anti-counterfeiting receiving and procurement procedures, including practical steps to spot fake goods and clear “hold” or “stop” actions when suspected.
- [ ] Set up the procurement and receiving process so that acceptance is only allowed after required proof of traceability is provided (part, serial number, or lot number, the certificate of conformity (COC) type, and a chain-of-custody reference).
- [ ] Carry out checks to confirm the evidence matches across the purchase order, packing list, and certificate identifiers. If any mismatch is found, stop the installation.
- [ ] Create a “quarantine/hold” status in the asset and configuration management database (CMDB) intake process that blocks installation until the security review and the supply-chain review are complete.
- [ ] Set up automated ticketing and escalation to the System Security Officer and the Supply Chain Risk Management Lead for any suspected or confirmed counterfeit finding.
- [ ] Define and enforce a decision log that can be audited for external reporting to the Cybersecurity and Infrastructure Security Agency (CISA), showing whether each item was reported or not reported, with the reason for the decision.


---

#### SR-11.1 — Anti-counterfeit Training (Enhancement)

This requirement is about making sure the right people in your organisation can identify fake or copied parts and software before they are added to your systems. Without this training, counterfeit hardware, software, or firmware could be supplied by third parties, which could cause unreliable performance, hidden weaknesses, fraud, or disruption that is difficult and expensive to fix later.

To meet this expectation, the organisation must train supply chain security officers, hardware and firmware engineers, software developers, and system administrators to recognise counterfeit components and to take clear steps to stop them entering the organisation’s systems. The training materials must specifically cover how to detect and prevent counterfeit hardware, software, and firmware. Staff must also be taught what to do if something looks suspicious, in line with the organisation’s anti-counterfeit policies and procedures.

The organisation must keep retrievable records showing who completed the training and confirming that the training covered both detection and prevention.

##### Role-based anti-counterfeit training for hardware, software, firmware

- Category: Manual
- Priority: High

###### WHAT
Deliver anti-counterfeit training to the roles defined by the organisation so they can **identify counterfeit system components** (hardware, software, and firmware) and **take the correct prevention actions** when suspicious items are identified.

###### WHY (control requirement)
SR-11(1) enhancement requires training for **{{ insert: param, sr-11.01_odp }}** to identify **counterfeit system components (including hardware, software, and firmware)**. The training must therefore clearly cover identification and the related prevention/response steps staff should take.

###### HOW (specific steps/approach)
1. **Create a role-to-training module matrix** for the defined roles: supply chain security officers, hardware/firmware engineers, software developers, and system administrators.
2. **Create three component-focused training tracks** within the programme:
   - **Hardware**: warning signs (for example, packaging/label/serial number irregularities, part-number inconsistencies, unexpected capabilities) and prevention actions (for example, stop accepting the item, capture evidence, quarantine the item, and escalate to the supplier).
   - **Software**: warning signs (for example, unexpected origin, mismatched build/version, suspicious files) and prevention actions (for example, stop deployment, verify origin, quarantine the files, and notify supply chain security).
   - **Firmware**: warning signs (for example, unexpected firmware build identifiers, version mismatches, unusual update behaviour) and prevention actions (for example, do not install unapproved firmware, escalate, and quarantine and document).
3. **Add scenario-based assessments** for each role, requiring learners to choose the correct order of actions (for example, suspicious component received → stop accepting/deploying → record evidence → escalate/report → quarantine → request/verify origin).
4. **Deliver through an auditable learning platform (learning management system (LMS) or equivalent)** with role-based assignment and completion checks (for example, privileged steps for supply chain acceptance, firmware/software releases, or administrative deployment require completion status).
5. **Keep training records that can be retrieved for audit**, including learner identity, role/module(s), completion date, assessment result (pass/fail), and evidence that the content covered **identification and prevention** across **hardware, software, and firmware**.
6. **Run regular re-certification** (at least annually, or when there is a significant supplier or process change) and monitor completion gaps by role.

###### WHO (responsible roles)
- **Supply Chain Security Officer / Security Governance Lead**: owns training requirements, approves content, and maintains audit evidence.
- **Hardware/Firmware Engineering Lead**: confirms the hardware/firmware identification warning signs and prevention steps.
- **Software Engineering Lead**: confirms the software identification warning signs and prevention steps.
- **System Administration Lead**: confirms the administration acceptance/escalation actions and operational constraints.
- **Learning Management Administrator**: sets up role-based assignments, completion checks, and reporting exports.

###### Acceptance criteria
- Each defined role has completed training that explicitly covers **counterfeit identification** for **hardware, software, and firmware**.
- Scenario assessments show learners selecting the correct **prevention/response actions** (stop accepting/deploying, capture evidence, escalate/report, quarantine).
- Training completion records are **retrievable** and include learner, role/module, completion date, and assessment result.
- Privileged or relevant operational actions are blocked or flagged until completion is recorded (where feasible within existing enterprise processes).

###### Actions Required for Compliance

- [ ] Define and publish a matrix showing which training each role needs for supply chain security officers, hardware and firmware engineers, software developers, and system administrators.
- [ ] Create training materials with separate sections for detecting and preventing counterfeit indicators in hardware, software, and firmware.
- [ ] Create scenario-based checks that require a step-by-step response for handling suspicious components: stop, preserve evidence, escalate, quarantine, and verify.
- [ ] Set up a learning management system (LMS) or equivalent to assign training modules based on job role, and require completion before any privileged work tasks are allowed.
- [ ] Set up report exports that can be audited and that record the learner’s identity, the module identifiers, the completion dates, and the assessment results.
- [ ] Arrange regular re-certification checks and monitor who has not completed them on time, by job role, with management reports.


---

#### SR-11.2 — Configuration Control for Component Service and Repair (Enhancement)

This requirement is about ensuring that every hardware and software item that is taken out of use for servicing or repair, and every item that has been serviced or repaired but has not yet been put back into use, is tracked and recorded accurately. Without this, the wrong part or software version could be put back into service, or an item could be changed without anyone noticing—leading to avoidable operational failures and increasing the risk that a faulty or tampered item is put back into use.

To meet this expectation, the organisation must keep a clear, up-to-date register of all in-scope items. For each item, the register must record:
- its unique identity
- its exact hardware details or software name and version
- whether it is awaiting service or repair, or awaiting return to service

Only authorised people may update the records, and they must keep a traceable history of what was changed and when. This tracking must start when the item is removed and continue until an authorised return to service is recorded. The organisation must also keep the relevant acquisition and service documentation, including any work carried out by other organisations.

##### Service/repair component register with auditable status transitions

- Category: Software
- Priority: Critical

###### WHAT
Set up an official, audit-friendly register to control **system components waiting for service or repair** and **serviced/repaired components waiting to be returned to service** (items in scope as defined by `sr-11.02_odp`).

###### WHY (control requirement)
SR-11(2) requires the organisation to **maintain configuration control** over the specified components in these two controlled states. This helps ensure the correct hardware and software configuration is returned to service, and that every change can be traced from removal through authorised return.

###### HOW (specific steps/approach)
1. **Create or extend one authoritative register** (a “configuration management database” approach, or a dedicated module) for in-scope components, with required information for every record:
   - Unique component identity (for example, asset tag or serial number)
   - Exact hardware details (part number, serial number, revision)
   - Exact software details (package name, version/build, and any relevant build identifier)
   - Current controlled state: **awaiting service/repair** or **serviced/repaired—awaiting return to service**
   - Date and time removed, and who/what role removed it
   - Current custody/location (including the controlled storage or transfer location)
   - Evidence of service/repair (for example, RMA number, service report/certificate, test results)
   - Date and time authorised return to service, and who/what role returned it or approved it
2. **Control movement between states using a workflow**, so records cannot move between the two controlled states (and onward) without the required evidence and approvals:
   - Only move to **serviced/repaired—awaiting return to service** when service evidence is attached or referenced.
   - Only move to **returned to service** when an authorised approver records the return and links the relevant service documentation.
3. **Make the register tamper-evident and auditable**:
   - Use “append-only” audit logs for every create, update, and state-change event.
   - Use role-based access control (RBAC) so only authorised configuration control operators and approvers can update records in controlled states.
   - Keep an unchangeable history (do not edit past values; changes create new audit entries).
4. **Link to existing inventory sources** to reduce errors while keeping control:
   - Pre-fill hardware and software identity/configuration from the enterprise asset inventory and software inventory.
   - Require a human check/confirmation when the component is placed into a controlled state.
5. **Support service/repair by other organisations**:
   - Record vendor/service provider identifiers and any relevant contract or service-level agreement (SLA) reference where applicable.
   - Store or reference service evidence produced by third parties and link it to the component record.

###### WHO (role responsible)
- **Configuration Management Lead / Configuration Management Database (CMDB) Owner**: owns the register design, data structure, and workflow.
- **Authorised Configuration Control Operators**: create and update records in controlled states.
- **Authorised Approvers (for example, Change/Release or Engineering Authority)**: approve state changes, especially return to service.
- **Service Desk / Logistics / Asset Custodian**: ensures custody/location and removal/return dates and times are recorded accurately.

###### Acceptance criteria
- For every in-scope component placed into either controlled state, there is a register entry with complete identity and exact hardware/software configuration details.
- State changes are only possible through the workflow and require linked evidence and authorised approvals.
- Every record event (creation, updates, state changes, evidence linking) is captured in an append-only audit trail that can be retrieved for audit.
- Third-party service/repair evidence is linked to the correct component record (using RMA/service report references) before the component is marked as awaiting return to service.
- Only authorised roles can create/update/approve controlled-state records; unauthorised attempts are blocked and logged.

###### Actions Required for Compliance

- [ ] Define the in-scope component data model for `sr-11.02_odp`, including a required identity, the exact hardware and software configuration, and the two controlled states.
- [ ] Set up a process that only allows changes into and out of the controlled states when there is supporting evidence and an authorised approval.
- [ ] Set up role-based access control (RBAC) so only authorised roles can create, update, or approve controlled-state records. Protect privileged actions with strong authentication.
- [ ] Set up audit logs for all register events so they can only be added to (not changed) and can show if someone has tampered with them, and keep the audit logs for as long as required by organisational policy.
- [ ] Link the register to the organisation’s hardware and software inventory so configuration details are filled in automatically, and require the operator to confirm the details when entering the state.
- [ ] Add fields and checks for third-party service or repair identifiers (for example, return merchandise authorisation (RMA) or service report references), and link them to the component record before approving the component for return to service.


---

#### SR-11.3 — Anti-counterfeit Scanning (Enhancement)

This requirement is about regularly checking that the parts your systems rely on are genuine and have not been copied, altered, or tampered with. If counterfeit parts enter your technology, they can quietly reduce reliability, expose sensitive information, or introduce hidden weaknesses that are difficult to detect later—potentially resulting in financial loss and disruption.

To meet this expectation, the organisation must scan for counterfeit system components at least once every week, using the correct type of scanning for each component type (for example, using the appropriate approach for web-based components when they are involved). The organisation must also keep clear records of which scanning tools were used for each weekly scan, including tool details where relevant, and must keep the scan results as evidence that the weekly checks are being completed.

##### Weekly counterfeit component scanning with tool-evidenced results

- Category: Software
- Priority: High

###### WHAT
Set up a weekly scanning capability that is suitable for each type of system component to detect counterfeit components, and keep audit-ready records showing (1) which scanning tools were used and (2) what the scans found.

###### WHY (control requirement)
SR-11(3) enhancement requires: **“Scan for counterfeit system components {{ insert: param, sr-11.03_odp }}.”** The organisation-defined parameter **sr-11.03_odp (frequency)** sets how often scans run (default **weekly**). Guidance also requires that the **type of component determines the type of scanning** (for example, web application scanning for web components).

###### HOW (specific steps/approach)
1. **Create and maintain an up-to-date component inventory** for the application and its supply chain items. Tag each component with a **component type** (for example: web application, API service, container image, package/library dependency, infrastructure-as-code module, third-party item).
2. **Set up a scheduled weekly scan job** (for example, a continuous integration and continuous delivery (CI/CD) scheduled workflow or an enterprise job scheduler) that:
   - uses the latest inventory targets,
   - runs **scans appropriate to each component type** (for example: static and dynamic application testing for web components; image scanning for container images; dependency scanning for libraries and packages; scanning of build outputs for build artefacts).
3. **Record tool details for every weekly scan** and link them to the evidence record, at minimum including: scanner/tool name, version (or build identifier), configuration/profile/rules used, and the target identifier(s) scanned.
4. **Keep the scan results and summaries** for each weekly run in a central, access-controlled evidence store, including timestamps and an unchangeable run identifier, so weekly scanning can be demonstrated during assessment.
5. **Put results into a standard evidence format** (for example, JSON plus a plain-language summary) so auditors can follow the chain: *weekly run → component targets → tool details → results*.
6. **Send high-confidence “counterfeit-likely” indicators** into the organisation’s supply chain risk / security triage process (do not stop the weekly scan; make sure the scan finishes and the evidence is saved).

###### WHO (role responsible)
- **Application Security Engineer / DevSecOps Engineer**: set up the scheduled scanning process, route scans by component type, and produce the evidence.
- **Security Operations / Supply Chain Risk Management lead**: define how to handle counterfeit-likely findings during triage.
- **Configuration/Release Manager**: ensure inventory tagging and target identifiers stay correct across environments (development/test/production/disaster recovery).

###### Acceptance criteria
- A weekly scan runs at least once every **week** (per **sr-11.03_odp frequency**).
- For each component type in the inventory, the scanning approach used matches that component type (per control guidance).
- For each weekly run, evidence includes **tool identity/version/configuration** and the **scan results** for the scanned targets.
- Evidence is kept centrally with unchangeable timestamps and can be retrieved by run ID for audit purposes.
- Counterfeit-likely indicators are triaged through the defined workflow, while weekly scanning continues to run and record evidence.

###### Actions Required for Compliance

- [ ] Define and keep an official, component-based list of all application parts and their dependencies.
- [ ] Set up a weekly scheduled scanning process that chooses scan targets from the inventory.
- [ ] Set up routing by component type so each component type uses the correct counterfeit scanning method.
- [ ] Record the scanner tool’s name, version (or build identifier), and the configuration/profile used for every weekly scan run.
- [ ] Store the original scan results and the cleaned-up summaries in a single, centrally managed evidence repository that only authorised users can access, using unique, unchangeable run identifiers.
- [ ] Create audit-ready evidence that links each weekly run identifier to the component targets, tool information, and results.
- [ ] Add information about counterfeit-likely findings to the supply chain risk and security “triage” process, without stopping the weekly collection of evidence.


---

### SR-12 — Component Disposal (Control)

This requirement is about making sure that when we no longer need a computer, router, or other device, we remove and destroy anything sensitive on it so it cannot be read, misused, or sold on. Without this, confidential information, sensitive documents, secret access codes, and data stored on the device could be recovered by unauthorised people, or the hardware could end up in the “grey market”.

The organisation must securely dispose of confidential and secret data, system documentation (paper or digital), cryptographic keys, and on-premises storage media on servers, routers, and endpoints at any point in the device’s life (including during development, testing, operations, or maintenance). This means properly wiping or clearing storage, destroying cryptographic keys, using secure physical destruction when wiping is not enough, and confirming that the device has been decommissioned completely, with a documented handover trail.

The organisation must also have clear policies and procedures covering supply-chain protection, assign named responsibilities, and keep disposal records showing which components were handled, what method was used, and how unauthorised access and grey-market risk were prevented.

##### SR-12 Disposal workflow with NIST 800-88 sanitisation evidence

- Category: Software
- Priority: Critical

###### WHAT
Set up an auditable, role-approved disposal process that securely disposes of the organisation-defined scope (confidential and secret information, system documentation, cryptographic keys, and on-premises storage media in servers, routers, and endpoints). Use the organisation-defined techniques and methods.

###### WHY (control requirement)
SR-12 requires that the organisation **dispose of** `{{ insert: param, sr-12_odp.01 }}` using **`{{ insert: param, sr-12_odp.02 }}`**. The guidance states that disposal can happen at any point in the life cycle (including research and development, design, prototyping, and operations/maintenance). It must prevent compromise of physical and logical data and reduce the risk of unauthorised resale.

###### HOW (specific steps/approach)
1. **Set disposal triggers across the life cycle** (for example: end-of-life, return material authorisation, moving from lab to testing, environment refresh, prototype scrap). Make sure the process is used whenever any in-scope item is removed from organisational control.
2. **Link disposal actions to the asset inventory**: each disposal request must reference an official asset record (serial/asset tag, device type, storage media type, encryption/key ownership status, and environment: production, test, development, disaster recovery).
3. **Choose the right sanitisation or destruction method automatically** based on the asset details and the organisation-defined `sr-12_odp.02` techniques (for example: media sanitisation that complies with National Institute of Standards and Technology Special Publication 800-88, cryptographic key destruction, secure physical destruction, and verified decommissioning with chain-of-custody). If sanitisation is not possible for the specific media/device, move to secure physical destruction.
4. **Make cryptographic key destruction mandatory** for assets that use cryptographic keys (for example: customer-managed keys or centrally managed keys). Keep evidence of key destruction or disabling (for example: key management service operation logs, key retirement records, or signed confirmations).
5. **Require evidence capture and release gates**: the process must stop final handover or export until the disposal record includes sanitisation evidence (for example: tool-generated sanitisation report identifiers/hashes), key destruction evidence, and proof that decommissioning is complete.
6. **Use chain-of-custody and approved handling**: record every custody transfer (who carried it out, who checked it, date and time, who received it, and the method used). If third parties are involved, ensure only approved/contracted disposal channels are used and record the receiving and verification documentation.
7. **Keep disposal records for audit**: store a tamper-evident disposal file for each asset/component, including: what was disposed of (data, documentation, keys, media), the method used, verification results, and the full chain-of-custody record.

###### WHO (role responsible)
- **IT/OT Asset Management Lead**: maintains the official asset inventory details needed to select the method.
- **Security Operations / Governance, Risk and Compliance (GRC)**: owns the SR-12 disposal process requirements, evidence standards, and auditability.
- **Infrastructure/Endpoint/Network Engineering**: carries out the sanitisation/destruction actions and provides tool outputs.
- **Privileged Approver (separation of duties)**: checks that evidence is complete and authorises release/handover.
- **Third-party Disposal Vendor Manager (if applicable)**: ensures only approved vendors are used and that evidence is returned.

###### Acceptance criteria
- For every disposal request covering in-scope items, the process produces an audit-ready disposal file that includes: asset identifier, in-scope item classification, the selected `sr-12_odp.02` method, sanitisation evidence, cryptographic key destruction evidence (where applicable), decommissioning verification, and chain-of-custody records.
- No asset leaves organisational control (including return material authorisation returns, lab scrap, or vendor handover) without evidence attached and sign-off from an authorised verifier.
- Assets that cannot be reliably sanitised are sent for secure physical destruction, with the corresponding verification evidence.
- The disposal process is used consistently for production, test, development, and disaster recovery refreshes, and for research and development/prototyping scrap events (not only at retirement).

###### Actions Required for Compliance

- [ ] Set up an SR-12 disposal process in the IT service management (ITSM) and asset system, with required fields for the in-scope item type, the asset identifiers, and the selected `sr-12_odp.02` disposal method.
- [ ] Integrate the workflow with the official asset inventory to automatically fill in the storage media and encryption key ownership details, so the system can choose the right method.
- [ ] Set up “release gates” for workflow handovers so the final handover/export cannot happen until sanitisation reports and verification evidence have been attached.
- [ ] Collect proof that cryptographic keys are securely destroyed or disabled when required (for example, records from a key management system (KMS) or signed confirmations) for the relevant assets.
- [ ] Ensure separation of duties by requiring different people to (1) perform and (2) verify sanitisation, key destruction, and decommissioning sign-off.
- [ ] Record every handover in the chain of custody (who transferred it, the date and time, who received it, and the approved method of transfer) and store the disposal records in a tamper-evident repository.
- [ ] Test the full workflow from start to finish for at least one server, one router, and one endpoint disposal scenario across both production and non-production refresh events.

